using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula_14dezembro
{
    public partial class inpulabol : Form
    {
        public inpulabol()
        {
            InitializeComponent();
        }
        public class ChecaForcaSenha
        {

            public enum ForcaDaSenha
            {
                Inaceitavel,
                Fraca,
                Aceitavel,
                Forte,
                Segura
            }

            public int geraPontosSenha(string senha)
            {
                if (senha == null) return 0;
                int pontosPorTamanho = GetPontoPorTamanho(senha);
                int pontosPorMinusculas = GetPontoPorMinusculas(senha);
                int pontosPorMaiusculas = GetPontoPorMaiusculas(senha);
                int pontosPorDigitos = GetPontoPorDigitos(senha);
                int pontosPorSimbolos = GetPontoPorSimbolos(senha);
                int pontosPorRepeticao = GetPontoPorRepeticao(senha);
                return pontosPorTamanho + pontosPorMinusculas +
                    pontosPorMaiusculas + pontosPorDigitos +
                    pontosPorSimbolos - pontosPorRepeticao;
            }

            private int GetPontoPorTamanho(string senha)
            {
                return Math.Min(10, senha.Length) * 7;
            }

            private int GetPontoPorMinusculas(string senha)
            {
                int rawplacar = senha.Length - Regex.Replace(senha, "[a-z]", "").Length;
                return Math.Min(2, rawplacar) * 5;
            }

            private int GetPontoPorMaiusculas(string senha)
            {
                int rawplacar = senha.Length - Regex.Replace(senha, "[A-Z]", "").Length;
                return Math.Min(2, rawplacar) * 5;
            }

            private int GetPontoPorDigitos(string senha)
            {
                int rawplacar = senha.Length - Regex.Replace(senha, "[0-9]", "").Length;
                return Math.Min(2, rawplacar) * 6;
            }

            private int GetPontoPorSimbolos(string senha)
            {
                int rawplacar = Regex.Replace(senha, "[a-zA-Z0-9]", "").Length;
                return Math.Min(2, rawplacar) * 5;
            }

            private int GetPontoPorRepeticao(string senha)
            {
                System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"(\w)*.*\1");
                bool repete = regex.IsMatch(senha);
                if (repete)
                {
                    return 30;
                }
                else
                {
                    return 0;
                }
            }

            public ForcaDaSenha GetForcaDaSenha(string senha)
            {
                int placar = geraPontosSenha(senha);

                if (placar < 50)
                    return ForcaDaSenha.Inaceitavel;
                else if (placar < 60)
                    return ForcaDaSenha.Fraca;
                else if (placar < 80)
                    return ForcaDaSenha.Aceitavel;
                else if (placar < 100)
                    return ForcaDaSenha.Forte;
                else
                    return ForcaDaSenha.Segura;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void inpulabol_Load(object sender, EventArgs e)
        {

        }

        //quando clicarmos no botão, apaga.
        private void botaoLimpar_Click(object sender, EventArgs e)
        {
            inputSenha.Text=""; // apaga o que está escrito dentro do inputSenha (textBox)
            labelMensagem.Text = "";// apaga o que está escrito dento do labelMensagem (label)
        }

      

        // Método para pegar o valor digitado no teclado
        private void verificaCaracter(object sender, KeyEventArgs e)
        {
            ChecaForcaSenha verifica = new ChecaForcaSenha();//cria um objeto chamado verifica para acessar a classe ChecaForcaSenha
            ChecaForcaSenha.ForcaDaSenha forca; // cria variável forca para guardar uma das informações(categorias da senha) do objeto ForcaDaSenha
            forca = verifica.GetForcaDaSenha(inputSenha.Text); // guarda na variável forca a informação se é aceitávél/forte/fraca DEPENDENDO do que eu digitar.
            labelMensagem.Text = forca.ToString(); // exibe o que está armazenado na variável forca, dentro da labelMensagem
        }
    }
}
