using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraComHistoricoTDD
{
    public class Calculadora
    {
        private List<string> _listHistorico;
        private string _data;

        public Calculadora(string data) {
            _listHistorico = new List<string>();
            _data = data;
        }
        public int Somar(int num1, int num2)
        {
            var soma = num1 + num2;

            _listHistorico.Insert(0, "Valor: " + soma + " - data: " + _data);
            return soma;
        }
        public int Subtrair(int num1, int num2)
        {
            var subtrair = num1 - num2;
            _listHistorico.Insert(0, "Valor: " + subtrair + " - data: " + _data);

            return subtrair;
        }

        public int Multiplicar(int num1, int num2)
        {
            var multiplicar = num1 * num2;

            _listHistorico.Insert(0, "Valor: " + multiplicar + " - data: " + _data);

            return multiplicar;
        }
        public int Dividir(int num1,int num2)
        {
            var dividir = num1 / num2;

            _listHistorico.Insert(0, "Valor: " + dividir + " - data: " + _data);


            return dividir;
        }

        public List<string> Historico()
        {
            List<string> resultado;

            _listHistorico.RemoveRange(3, _listHistorico.Count - 3);

            return _listHistorico;
        }
    }

}
