using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício1
{
    class Calculos
    {
        private int numero;
        private float numeroRecebido;
        private int expoenteRecebido;
        private float numeroRecebido2;
        private float porcentagemInt;
        private float nase;
        private float altura;
        public int Fatorial()
        {
            int cont;
            int resultado;

            cont = numero - 1;
            resultado = numero * cont;
            cont--;

            do
            {
                resultado *= cont;
                cont--;
            }
            while (cont != 1);

            return resultado;
        }

        public float Exponenciacao()
        {
            int expoente = 1;
            float numero2;
            numero2 = numeroRecebido;
            do
            {
                numeroRecebido *= numero2;
                expoente++;
            }
            while (expoente != expoenteRecebido);

            return numeroRecebido;
        }

        public float Porcentagem()
        {
            float porcentagemDecimal;
            float resultado;

            porcentagemDecimal = porcentagemInt / 100;

            resultado = numeroRecebido2 * porcentagemDecimal;

            return (resultado);
        }

        public float Area()
        {
            float area;

            area = (nase * altura) / 2;

            return area;
        }

        public Calculos() { this.Numero = numero; }
        public int Numero { get { return numero; } set { numero = value; } }
        public int ExpoenteRecebido { get { return expoenteRecebido; } set { expoenteRecebido = value; } }
        public float NumeroRecebido { get { return numeroRecebido; } set { numeroRecebido = value; } }
        public float NumeroRecebido2 { get { return numeroRecebido2; } set { numeroRecebido2 = value; } }
        public float PorcentagemInt { get { return porcentagemInt; } set { porcentagemInt = value; } }
        public float Nase { get { return nase; } set { nase = value; } }
        public float Altura { get { return altura; } set { altura = value; } }

    }


}
