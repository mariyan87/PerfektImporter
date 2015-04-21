using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfektImporter
{
    class PerfektTXTImporter
    {
        StringBuilder _sb = null;
        List<XmlColumnFormat> _xmlColFormats = null;
        string _dateFormat;

        public PerfektTXTImporter(List<XmlColumnFormat> xmlColFormats, string dateFormat)
        {
            _xmlColFormats = xmlColFormats;
            _dateFormat = dateFormat;
        }

        private void WriteLine(string line, decimal docNum, BuySell buySell)
        {
            string bulstat = "";
            string bgBulstat = "";
            string subject = "";
            DateTime accDate = DateTime.MinValue;
            DateTime docDate = DateTime.MinValue;
            //string bulstatDoc = line.Substring(72, 9);
            string performer = "";
            string operation = "";
            decimal fee = 0;
            decimal bruto = 0;

            string info = Common.TEXT_invoice;
            DocKind docKind = DocKind.Invoice;

            switch (docKind)
            {
                case DocKind.Invoice:
                    info = Common.TEXT_invoice;
                    break;
                case DocKind.Debit:
                    info = Common.TEXT_debit;
                    break;
                case DocKind.Credit:
                    docKind = DocKind.Credit;
                    info = Common.TEXT_credit;
                    break;
            }

            int dtAcc = Common.DT_ACC_BUY;
            int crAcc = 501;//702
            int operCode = 102;

            switch (buySell)
            {
                case BuySell.Sell:
                    dtAcc = Common.DT_ACC_SELL;
                    crAcc = Common.CR_ACC_SELL;
                    operCode = 201;//201 - Продажба - (11-12) доставка и дист. продажби със ставка 20%
                    break;
                case BuySell.Buy:
                    dtAcc = Common.DT_ACC_BUY;
                    crAcc = Common.CR_ACC_BUY;
                    operCode = 102;//102 - Покупка - (10-11) доставка,внос и ВОП с ДДС и ДК
                    break;
            }

            foreach (XmlColumnFormat colFormat in _xmlColFormats)
            {
                string xmlTagName = colFormat.XmlTag.ToString();

                switch (colFormat.XmlTag)
                {
                    case XmlTags.ACCDATE:
                        accDate = DateTime.ParseExact(line.Substring(colFormat.StartIndex, colFormat.Length) + "01", _dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None);
                        break;
                    case XmlTags.DOCDATE:
                        docDate = DateTime.ParseExact(line.Substring(colFormat.StartIndex, colFormat.Length), _dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None);
                        break;
                    case XmlTags.OPERATION:
                        break;
                    case XmlTags.PERFORMER:
                        performer = line.Substring(colFormat.StartIndex, colFormat.Length).Trim();
                        break;
                    case XmlTags.BGBULSTAT:
                        bgBulstat = line.Substring(colFormat.StartIndex, colFormat.Length);
                        break;
                    case XmlTags.BULSTAT:
                        bulstat = line.Substring(colFormat.StartIndex, colFormat.Length);
                        break;
                    case XmlTags.SUBJECT:
                        subject = line.Substring(colFormat.StartIndex, colFormat.Length).Trim();
                        break;
                    case XmlTags.SUM:
                        break;
                    case XmlTags.BRUTO:
                        bruto = Common.ParseDecimal(line.Substring(colFormat.StartIndex, colFormat.Length).Trim());
                        break;
                    case XmlTags.FEE:
                        fee = Common.ParseDecimal(line.Substring(colFormat.StartIndex, colFormat.Length).Trim());
                        break;
                    default:
                        break;
                }
            }

            if (docDate > accDate)
            {
                accDate = docDate;
            }

            _sb.Append(@"	
 <TDOCUMENT>
  <DOCKIND>").Append(docKind).Append(@"</DOCKIND>
  <OPERCODE>").Append(operCode).Append(@"</OPERCODE>
  <ACCDATE>").Append(accDate.ToString("dd.MM.yyyy")).Append(@"</ACCDATE>
  <DOCDATE>").Append(docDate.ToString("dd.MM.yyyy")).Append(@"</DOCDATE>
  <DOCNO>").Append(docNum.ToString().PadLeft(10, '0')).Append(@"</DOCNO>
  <FOLDER>").Append((int)buySell).Append(@"</FOLDER>
  <INFO>").Append(info).Append(@"</INFO>
  <OPERATION>").Append(operation).Append(@"</OPERATION>
  <SUBJECT>").Append(subject).Append(@"</SUBJECT>
  <PERFORMER>").Append(performer).Append(@"</PERFORMER>
  <BULSTAT>").Append(bulstat).Append(@"</BULSTAT>
  <BGBULSTAT>").Append(bgBulstat).Append(@"</BGBULSTAT>
  <TDOC_ITEM>
    <DT_ACC>").Append(dtAcc).Append(@"-----</DT_ACC>
    <CR_ACC>").Append(crAcc).Append(@"-----</CR_ACC>
    <SUM>").Append(bruto + fee).Append(@"</SUM>
    <BRUTO>").Append(bruto).Append(@"</BRUTO>
    <FEE>").Append(fee).Append(@"</FEE>
    <DDS>20.00</DDS>
  </TDOC_ITEM>
</TDOCUMENT>");
        }

        internal string GenerateXML(BuySell buySell, string sourceText, decimal docNum)
        {
            _sb = new StringBuilder("<?xml version='1.0' encoding='ISO-8859-1' ?>");
            _sb.AppendLine();
            _sb.AppendLine("<TDOC_LIST>");

            string[] lines = sourceText.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            foreach (string line in lines)
            {
                WriteLine(line, docNum, buySell);
                docNum++;
            }

            _sb.AppendLine("</TDOC_LIST>");

            return _sb.ToString();
        }
    }
}
