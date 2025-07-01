public class MaquinaCafe
{
    private Dictionary<string, int> tamanos = new Dictionary<string, int>()
 {
 {"Pequeno", 3},
 {"Mediano", 5},
 {"Grande", 7}
 };
    public string Dispensar(string tamano, int azucar)
    {
        if (!tamanos.ContainsKey(tamano))
            return "Tamaño no válido";
        if (azucar < 0)
            return "Cantidad de azúcar inválida";
        int cantidad = tamanos[tamano];
        return $"Entregando {cantidad} oz de café con {azucar} cucharada(s) de azúcar";
    }

} 
