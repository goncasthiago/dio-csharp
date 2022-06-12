using static System.Console;

namespace POO.model
{
    public class Data
    {
        private int Mes;
        public int mes
        {
            get
            {
                return this.mes;
            }
            set
            {
                if (value > 0 && value <= 12)
            {
                this.mes = value;
                this.mesValido = true;
            }
            }
        }
        private bool MesValido;
        private bool mesValido;

        public int GetMes()
        {
            return this.Mes;
        }

        public void SetMes(int mes)
        {
            if (mes > 0 && mes <= 12)
            {
                this.Mes = mes;
                this.MesValido = true;
            }
        }
        public void Apresenta()
        {
            if (this.MesValido)
            {
                WriteLine($"O mês é: {this.Mes}");
            }
            else
            {
                WriteLine($"Mês inválido, favor cadastrar o mês corretamente");

            }
        }
    }
}