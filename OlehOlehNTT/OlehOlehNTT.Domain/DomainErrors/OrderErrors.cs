using OlehOlehNTT.Domain.Shared;

namespace OlehOlehNTT.Domain.DomainErrors;

public static class OrderErrors
{
    public static readonly Error UserAlreadyHaveActiveOrder = new("Order.UserAlreadyHaveActiveOrder", "Pengguna sudah memiliki transaksi aktif");
    public static readonly Error AddToUnactiveOrder = new("Order.AddToUnactiveOrder", "Tidak dapat menambah item pada transaksi tidak aktif");
    public static readonly Error StokProdukNotEnough = new("Order.StokProdukNotEnough", "Stok produk tidak cukup");

    public static readonly Error RemoveFromUnactiveOrder = new(
        "Order.RemoveFromUnactiveOrder", 
        "Tidak dapat menghapus item pada transaksi tidak aktif");

    public static readonly Error AlreadyHaveProduk = new("Order.AlreadyHaveItemWithProduk", "Produk sudah ada dalam transaksi");
    public static readonly Error OrderItemNotExist = new("Order.OrderItemNotExist", "Item transaksi tidak ditemukan");
    public static readonly Error AlreadyCheckout = new("Order.AlreadyCheckout", "Transaksi sudah checkout");
    public static readonly Error CheckoutWithEmptyOrderItems = new(
        "Order.CheckoutWithEmptyOrderItems", 
        "Tidak dapat checkout tanpa ada item di keranjang");
}
