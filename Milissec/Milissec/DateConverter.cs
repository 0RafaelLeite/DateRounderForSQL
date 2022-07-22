using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milissec
{
    public class DateConverter
    {
        public DateTime DataAtual { get; set; }

        public DateConverter(DateTime dataAtual)
        {
            this.DataAtual = dataAtual;
        }

        public void ArredondaData()
        {
            var MsAtual = DataAtual.Millisecond;
            int cent = MsAtual / 100;
            int dez = (MsAtual - cent * 100) / 10;
            int uni = (MsAtual - cent * 100) - dez * 10;
            DateTime DataArredondada;

            switch (uni)
            {
                case 1:
                    DataArredondada = DataAtual.AddMilliseconds(-1);
                    DataAtual = DataArredondada;
                    break;
                case 2:
                    DataArredondada = DataAtual.AddMilliseconds(1);
                    DataAtual = DataArredondada;
                    break;
                case 4:
                    DataArredondada = DataAtual.AddMilliseconds(-1);
                    DataAtual = DataArredondada;
                    break;
                case 5:
                    DataArredondada = DataAtual.AddMilliseconds(2);
                    DataAtual = DataArredondada;
                    break;
                case 6:
                    DataArredondada = DataAtual.AddMilliseconds(1);
                    DataAtual = DataArredondada;
                    break;
                case 8:
                    DataArredondada = DataAtual.AddMilliseconds(-1);
                    DataAtual = DataArredondada;
                    break;
                case 9:
                    DataArredondada = DataAtual.AddMilliseconds(1);
                    DataAtual = DataArredondada;
                    break;
                default:
                    break;
            }
        }
    }
}
