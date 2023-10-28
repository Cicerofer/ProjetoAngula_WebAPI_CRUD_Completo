namespace WebApiBase.Model
{
    public class ServiceResponse<T>//dado genérico
    {
        public T? Dados { get; set; }// pode ser nulo
        public string Mensagem { get; set; } = string.Empty;// string vazia
        public bool Sucesso { get; set; } = true; // ja iniica como verdadeira
    }
}
