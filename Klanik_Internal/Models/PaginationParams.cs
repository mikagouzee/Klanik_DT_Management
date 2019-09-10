namespace Klanik_Internal.Models {
    public class PaginationParams {
        public object columnFilters { get; set; }
        public Sort sort { get; set; }
        public int page { get; set; } = 1;
        public int perPage { get; set; } = 10;
    }

    public class Sort {
        public string field { get; set; }
        public string type { get; set; }
    }
}