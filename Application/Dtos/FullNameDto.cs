namespace Application.Dtos;

public class FullNameDto
{
        public FullNameDto FullName { get; init; }
    
    /// <summary>
        /// Имя
        /// </summary>
        public string FirstName { get; set; }
        
        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName { get; set; }
        
        /// <summary>
        /// Отчество
        /// </summary>
        public string? FatherName { get; set;}
}