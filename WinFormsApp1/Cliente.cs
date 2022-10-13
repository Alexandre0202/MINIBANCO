namespace WinFormsApp1
{
    public class Cliente : Pessoa
    {
        public Cliente()
        {
            this.Categoria = "Cliente";
        }
        public void GerarNota()
        {
            string nota =
                string.Format("Categoria: {0}"+"\n"+
                              "Nome: {1}" +"\n"+
                              "CPF: {2}" + "\n" +
                              "Telefone: {3}",
                              this.Categoria,this.Nome,this.CPF,this.Telefone);
            Console.WriteLine(nota);
        }
    }
}
