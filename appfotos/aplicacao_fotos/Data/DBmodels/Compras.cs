namespace aplicacao_fotos.Data.DBmodels;

public class Compras
{
    public int ID { get; set; }
    public DateTime Data { get; set; }
    public EstadoCompras Estado { get; set; }
    
}
public enum EstadoCompras
{
    iniciada,
    paga,
    enviado,
    concluido
}