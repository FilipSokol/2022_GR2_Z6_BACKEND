﻿using StudentServiceSystemAPI.Models;

namespace StudentServiceSystemAPI.DtoModels
{
    public class SubjectsWithStudentsDto
    {
        public string Name { get; set; }

        public int SubjectId { get; set; }
        public List<StudentWithMarksDto> Students { get; set; }
    }
}
