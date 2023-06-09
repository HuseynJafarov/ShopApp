﻿namespace Service.DTOs.Cart
{
    public class CartListDto
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Image{ get; set; }
        public double Price { get; set; }
        public DateTime Date { get; set; }
        public DateTime UpdateDate { get; set; }
        public List<string>? AuthorName { get; set; }
        public List<string>? StudentFullName { get; set; }
    }
}
