using OlehOlehNTT.Domain.Shared;

namespace OlehOlehNTT.Domain.DomainErrors;

public static class OrderErrors
{
    public static readonly Error UserAlreadyHaveActiveOrder = new("Order.UserAlreadyHaveActiveOrder", "Pengguna sudang memiliki transaksi aktif");

    public static readonly Error AddToUnactiveOrder = new("Order.AddToUnactiveOrder", "Tidak dapat menambah item pada transaksi tidak aktif");

    public static readonly Error StokProdukNotEnough = new("Order.StokProdukNotEnough", "Stok produk tidak cukup");

    public static readonly Error RemoveFromUnactiveOrder = new("Order.RemoveFromUnactiveOrder", "Tidak dapat menghapus item pada transaksi tidak aktif");

    public static readonly Error ItemWithProdukNotExist = new("Order.ItemWithProdukNotExist", "Produk tidak ada dalam transaksi");
}
