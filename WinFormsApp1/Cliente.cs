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
                              "Nome: {0}" +"\n"+
                              "CPF: {1}" + "\n" +
                              "Telefone: {2}",
                              this.Categoria,this.Nome,this.CPF,this.Telefone);
            Console.WriteLine(nota);
        }
    }
}
