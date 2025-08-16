namespace ConstructorsAndInitialization
{
    internal class Car
    {
        //brand ve sınıfın alanları(fiesldları) ve biz bu alanlarda veriler tutarız.
        public string Brand;
        public string Speed;
        public string FlyCode = "TK"; //fied Initializers

        //public-private-internal : erişim belirteci 
        //string-int-float-bool-... : veri tipi.
        //Brand-Speed-FlyCode : FieldName, biz bunun üzerinden erişip veri ile işlem gerçekleştireceğiz.
        //başlangıç değeri: Hafızada hangi değer tutuyor. Bu ödnekte FlyCode nin başlangıç değer TK, Speed in başlangıç değeri nulldur.

        ///classın fildlerının ve propertieslerinin başlangıç değeri olması gerkmektedir.
        ///c# bunun birkaç yolu vardır. 
        ///----
        ///a. varsayılan değer
        ///sayısal türlerde(int, doule...) başlangıç değeri 0 dır.
        ///referans türlerde(string, object...) sayısal değer null.
        ///boolean da sayısal değer false dir.
        ///---
        ///Eğer bir fied veya bir properties için farklı bir değer gerekli ise, varsayılan değerden farklı bir değer ile başlatılması gerekmektedir.
        ///başlangıç değerini değiştirmek için birkaç yöntem vardır.
        ///---

        #region fied Initializers(alan başlatıcılar)
        ///Fieldlara başlangıç değeri atar.
        ///Fieldlara başlangıö değeri aşağıdaki gibi atanır.

        private string Model = "Togg T10X";
        #endregion

        #region Constructors (yapıcılar)
        ///bir Classı oluştururken field veya properties başlatmanın en yaygın yolu Constructors kullanmaktır
        ///Classın bir nesnesi oluştuğunda çalışan methodtur.
        ///Nesnenin başlangıç durumunda ayarlamalar yapmak için kullanılır.
        ///Otomatik olarak çalışır. amaç nesnenin başlatılmasını sağlamak.
        ///Classların başlangıç değerine aşağıdaki gibi müdahale edilir.

        public Car(string brand, string speed)
        {
            Brand = brand; //Büyük harfle başlayan veri tabanına kaydolur. Küçük harfle başlayan ise kullanıcıdan alırız.
            Speed = speed;
        }


        //Car car = new Car("BMV", "230"); //bunu program cs te yaz.



        #region Defferent EXAMPLE

        //Field initialize edildi.
        public string NumberOfDor = "15";
        public string Color = "Black";

        //class default değerlerle başladı.
        public Car() { }
        #endregion

        #region Ensuring the Setting of Mandatory Fields:

        //Zorunlu alanların ayarlanmasını sağlamak

        public string GasSituation;

        public Car(string gasSituation)
        {
            if (string.IsNullOrEmpty(gasSituation))
            {
                throw new ArgumentException("Hata, gaz boş olamaz.");
            }

            GasSituation = gasSituation;
        }

        #endregion


        #endregion


    }
}
