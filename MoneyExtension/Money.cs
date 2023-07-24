namespace MoneyExtension;

public static class Money
{
    public static int ToCents(this decimal valor)
    {
        var strValor = valor.ToString("N2").Replace(",", "").Replace(".", "");

        if (string.IsNullOrEmpty(strValor)) return 0;

        int.TryParse(strValor, out int cents);

        return cents;
    }
}
