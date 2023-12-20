namespace TestesUnitarios.Desafio.Console.Services
{
    public class ValidacoesString
    {
        //Recebe um texto qualquer e retorna a quantidade de caracteres presentes no texto
        public int RetornarQuantidadeCaracteres(string texto)
        {
            var numeroCaracteres = texto.Length;
            return numeroCaracteres;
        }
        //Recebe um texto qualquer e um texto a ser procurado, retorna verdadeiro ou falso se um determinado trecho procurado está presente no texto
        public bool ContemCaractere(string texto, string textoProcurado)
        {
            var contem = texto.Contains(textoProcurado);
            return contem;
        }
        //Recebe um texto qualquer e um trecho a ser procurado, retorna verdadeiro ou falso se um determinado trecho procurado está presente no final do texto apenas
        public bool TextoTerminaCom(string texto, string textoProcurado)
        {
            var termina = texto.EndsWith(textoProcurado);
            return termina;
        }
    }
}