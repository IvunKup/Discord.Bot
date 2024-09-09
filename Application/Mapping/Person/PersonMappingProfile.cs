namespace DefaultNamespace;

public class PersonMappingProfile
{
    public MappingProfile()
    {
        CreateMap<FullNameDto, FullName>()
            .ConstructUsing(dto => new FullName(dto.FirstName, dto.LastName, dto.FatherName));
        
        CreateMap<FullName, FullNameDto>();
    }
}