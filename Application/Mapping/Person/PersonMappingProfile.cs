namespace DefaultNamespace;

public class PersonMappingProfile
{
    public MappingProfile()
    {
        CreateMap<FullNameDto, FullName>()
        
        CreateMap<FullName, FullNameDto>()
            
        CreateMap<CreatePersonRequest, Person>()

        CreateMap<Person, CreatePersonRequest>()
            
        CreateMap<CreatePersonResponse, Person>()

        CreateMap<Person, CreatePersonResponse>()

		CreateMap<PersonUpdateRequest, Person>()

        CreateMap<Person, CreatePersonResponse>()

		CreateMap<PersonUpdateResponse, Person>()

        CreateMap<Person, CreatePersonResponse>()
        
        CreateMap<PersonGetAllResponse, Person>()
        
        CreateMap<Person, PersonGetAllResponse>()
        
        CreateMap<PersonGetBuildResponse, Person>()
                
        CreateMap<Person, PersonGetBuildResponse>();
    }
}