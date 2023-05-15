using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoWindowsForms
{
    public class Conta
    {
        private int _numeroAgencia;
        private string _conta;
        private double _saldo;

        public Cliente Titular { get; set; }

        public string NomeAgencia { get; set; }

        public int NumeroAgencia
        {
            get
            {
                return _numeroAgencia;
            }
            set
            {
                if (value > 0)
                {
                    _numeroAgencia = value;
                }
            }
        }

        public string ContaCorrente
        {
            get
            {
                return _conta;
            }
            set
            {
                if (value != null)
                {
                    _conta = value;
                }
            }
        }

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (!(value < 0.0))
                {
                    _saldo = value;
                }
            }
        }

        public static int TotalContasCriadas { get; set; }

        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }
            if (valor < 0.0)
            {
                return false;
            }
            Saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            if (!(valor < 0.0))
            {
                _saldo += valor;
            }
        }

        public bool Transferir(double valor, Conta destino)
        {
            if (_saldo < valor)
            {
                return false;
            }
            if (valor < 0.0)
            {
                return false;
            }
            _saldo -= valor;
            destino.Saldo += valor;
            return true;
        }

        public Conta(int _numeroAgencia)
        {
            NumeroAgencia = _numeroAgencia;
            Conta = Guid.NewGuid().ToString().Substring(0, 8);
            Titular = new Cliente();
            TotalContasCriadas++;
        }

        public Conta(int _numeroAgencia, string _conta)
        {
            NumeroAgencia = _numeroAgencia;
            Conta = _conta;
        }

        public Conta()
        {
        }

        public override string ToString()
        {
            return $"=== DADOS DA CONTA ===\nNúmero da Conta: {this.Conta}\nTitular da Conta: {this.Titular.Nome}\nCPF: {this.Titular.Cpf}\nProfissão: {this.Titular.Profissao}";
        }
    }

    public partial class ContaBanco : Form
    {
        private ContaBanco[] contas;

        private void Form1_load(object sender, EventArgs e)
        {
            contas = new ContaBanco[3];

            this.contas[0] = new Conta();
            this.contas[0].Titular = new Cliente("victor");
            this.contas[0].Numero = 1;

            this.contas[1] = new ContaPoupanca();
            this.contas[1].Titular = new Cliente("mauricio");
            this.contas[1].Numero = 2;

            this.contas[2] = new ContaCorrente();
            this.contas[2].Titular = new Cliente("osni");
            this.contas[2].Numero = 3;
        }
    }
}
}

