using AutoMapper;
using bookstore.DTO;
using bookstore.Models;

namespace bookstore.AutoMapper;

public class Mapping : Profile
{
    public Mapping()
    {
        CreateMap<Book, BookDTO>();
    }
}