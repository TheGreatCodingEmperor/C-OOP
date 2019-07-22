namespace lesson1{
    public class Customer{
        public int CustomerID {get; private set;}
        public string LastName {get; set;}
        public string FirstName {get; set;}
        public void Save(){}
        public void Load(){}
    }
    public class Product{
        public int ProductID {get; private set;}
        public string ProductName {get; set;}
        public string ProductDescription{get; set;}
        public int? CurrentPrice {get; set;}
    }
}