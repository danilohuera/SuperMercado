namespace SumerMercado
{
    public abstract class Product
    {
        public string Description { get; set; }
        public int Id { get; set; }
        public decimal Price { get; set; }
        public float Tax { get; set; }

        public abstract decimal ValueToPay();

        public override string ToString()
        {
            return $"{Id}  " +
                $"\n\t Producto.........: {$"{Description}",18} " +
                $"\n\t Precio...........: {$"{Price:C2}",18} " +
                $"\n\t Tax..............: {$"{Tax:P2}",18} ";
        }
        public Product()
        {

        }
    }
}
