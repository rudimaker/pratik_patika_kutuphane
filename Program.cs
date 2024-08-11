using pratik_patika_kutuphane;

Book kitap1 = new Book("Aylin", "Ayşe","Kulin",398,"Remzi Kitapevi");

Book kitap2 = new Book();
{
    kitap2.KitapAd = "Fareler ve İnsanlar";
    kitap2.YazarAd = "John";
    kitap2.YazarSoyad = "Steinbeck";
    kitap2.SayfaSayısı = 155;
    kitap2.YayınEvi = "İletişim Yayınevi";
}

kitap1.DisplayList();
kitap2.DisplayList();