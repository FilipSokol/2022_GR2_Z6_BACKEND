
# Student Service System

Aplikacja ułatwiająca zarządzanie studentami.




## Wykorzystane technologie

**Client:** React, SCSS, Axios, Vite

**Server:** C#, .NET 6, MsSql

**Mobile:** React Native, TypeScript, Expo


## Spis treści

 - [Wymagania Funkcjonalne](#wymagania-funkcjonalne)
 - [Wymagania Niefunkcjonalne](#wymagania-niefunkcjonalne)
 - [Diagram Klas](#diagram-klas)
 - [Model Bazy Danych](#model-bazy)
 - [Model Architektury](#model-architektury)
 - [Endpointy](#endpointy)
 

## Wymagania Funkcjonalne
<a name="wymagania-funkcjonalne"></a>
 - Użytkownik może zarejestrować się oraz zalogować do aplikacji.
 - Użytkownik może wyświetlić swoje dane i w zależności od roli wykonywać adekwatne akcje na stronie.
 - Użytkownik z rolą Nauczyciela może wystawiać studentom oceny.
 - Użytkownik z rolą Admin może przypisywać studentów do grup.

## Wymagania Niefunkcjonalne
<a name="wymagania-niefunkcjonalne"></a>
 - Aplikacja powinna być cross-platformowa.
 - Wykorzystanie technologii ASP.NET Core 6.0 / MS SQL / React Native 0.70 / ReactJS 18.2.0
 - Dokumentacja techniczna oparta na Swashbuckle Swagger.

## Diagram Klas
<a name="diagram-klas"></a>
Poniżej zamieszczone są główne klasy wykorzystane w części Backendu.

![alt text](https://raw.githubusercontent.com/FilipSokol/2022_GR2_Z6_BACKEND/master/Img/ClassDiagram.png)
## Model Bazy Danych
<a name="model-bazy"></a>
Model

![alt text](https://raw.githubusercontent.com/FilipSokol/2022_GR2_Z6_BACKEND/master/Img/database_model.png)
## Model Architektury
<a name="model_architektury"></a>
![alt text](https://raw.githubusercontent.com/FilipSokol/2022_GR2_Z6_BACKEND/master/Img/Architecture.png)


## Endpointy
<a name="endpointy"></a>
Każdy z obiektów biznesowych posiada własny endpoint umożliwiający tworzenie, odczytywanie, modyfikację oraz usuwanie obiektu z bazy danych.

Poniżej przedstawiono endpointy wraz z metodami:
| Parametr | Typ     | Opis                |
| :-------- | :------- | :------------------------- |
| **TBD**`JWT Bearer` | `string` | **Wymagany**. Dla wszystkich operacji wymagany jest token autentykacyjny |

### Departments:

#### Wyświetl wszystkie obiekty typu Department:
```http
  GET /api/departments
```

#### Wyświetl obiekt typu Department o podanym Id
```http
  GET /api/departments/${id}
```

| Parametr | Typ     | Opis                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `int` | **Wymagane**. Id wydziału |


#### Dodaj obiekt typu Department

```http
  POST /api/departments
```

| Body | Typ     | Opis                       |
| :-------- | :------- | :-------------------------------- |
| `CreateDepartmentDto` | serialized json | **Wymagane**. Id wydziału |

#### Przykład body CreateDepartmentDto
```yaml
{
   "Name": "Wydział Inżynierii",
   "Address": "Zielona 3",
   "City": "Częstochowa",
   "PostalCode": "42-700"
}
```
#### Edytuj obiekt typu Department

```http
  PUT /api/departments/{id}
```

| Body | Typ     | Opis                       |
| :-------- | :------- | :-------------------------------- |
| `UpdateDepartmentDto` | serialized json | **Wymagane**. Id wydziału |

#### Przykład body UpdateDepartmentDto
```yaml
{
   "Name": "Wydział Inżynierii",
   "Address": "Zielona 3",
   "City": "Częstochowa",
   "PostalCode": "42-700"
}
```

#### Usuń obiekt typu Department o podanym Id
```http
  DELETE /api/departments/${id}
```

| Parametr | Typ     | Opis                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `int` | **Wymagane**. Id wydziału |


### Groups:

#### Wyświetl wszystkie obiekty typu Group:
```http
  GET /api/departments/{departmentId}/groups
```
| Parametr | Typ     | Opis                       |
| :-------- | :------- | :-------------------------------- |
| `departmentId`      | `int` | **Wymagane**. Id wydziału |

#### Wyświetl obiekt typu Group o podanym Id
```http
  GET /api/departments/{departmentId}/groups/{groupId}
```

| Parametr | Typ     | Opis                       |
| :-------- | :------- | :-------------------------------- |
| `departmentId`      | `int` | **Wymagane**. Id wydziału |
| `groupId`      | `int` | **Wymagane**. Id grupy |

#### Dodaj obiekt typu Group

```http
  POST /api/departments/{departmentId}/groups
```
| Parametr | Typ     | Opis                       |
| :-------- | :------- | :-------------------------------- |
| `departmentId`      | `int` | **Wymagane**. Id wydziału |

| Body      | Typ     | Opis                       |
| :-------- | :------- | :-------------------------------- |
| `CreateGroupDto` | serialized json | **Wymagane**. Dane tworzonego Deparamentu |

#### Przykład body CreateDepartmentDto
```yaml
{
   "Name": "group_2022_2",
}
```
#### Edytuj obiekt typu Group

```http
  PUT /api/departments/{departmentId}/groups/{groupId}
```
| Parametr | Typ     | Opis                       |
| :-------- | :------- | :-------------------------------- |
| `departmentId`      | `int` | **Wymagane**. Id wydziału |
| `groupId`           | `int` | **Wymagane**. Id grupy |

| Body      | Typ     | Opis                       |
| :-------- | :------- | :-------------------------------- |
| `UpdateGroupDto` | serialized json | **Wymagane**. Dane tworzonego Deparamentu |

#### Przykład body UpdateGroupDto
```yaml
{
   "Name": "group_2022_2",
}
```

#### Usuń obiekt typu Group o podanym Id
```http
  DELETE /api/departments/{departmentId}/groups/{groupId}
```

| Parametr | Typ     | Opis                       |
| :-------- | :------- | :-------------------------------- |
| `departmentId`      | `int` | **Wymagane**. Id wydziału |
| `groupId`      | `int` | **Wymagane**. Id grupy |

#### Usuń wszystkie obiekty typu Group dla danego wydziału
```http
  DELETE /api/departments/{departmentId}/groups
```

| Parametr | Typ     | Opis                       |
| :-------- | :------- | :-------------------------------- |
| `departmentId`      | `int` | **Wymagane**. Id wydziału |

### Students:

#### Wyświetl wszystkie obiekty typu Student:
```http
  GET /api/departments/{departmentId}/groups/{groupId}/students
```
| Parametr | Typ     | Opis                       |
| :-------- | :------- | :-------------------------------- |
| `departmentId`      | `int` | **Wymagane**. Id wydziału |
| `groupId`      | `int` | **Wymagane**. Id grupy |

#### Wyświetl obiekt typu Student o podanym Id
```http
  GET /api/students/{id}
```

| Parametr | Typ     | Opis                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `int` | **Wymagane**. Id studenta |


#### Dodaj obiekt typu Student

```http
  POST /api/departments/{departmentId}/groups/{groupId}/students
```
| Parametr | Typ     | Opis                       |
| :-------- | :------- | :-------------------------------- |
| `departmentId`      | `int` | **Wymagane**. Id wydziału |
| `groupId`           | `int` | **Wymagane**. Id grupy |

| Body      | Typ     | Opis                       |
| :-------- | :------- | :-------------------------------- |
| `CreateStudentDto` | serialized json | **Wymagane**. Dane tworzonej grupy  |

#### Przykład body CreateStudentDto
```yaml
{
   "FirstName": "Jan",
   "LastName": "Kowalski"
}
```

#### Edytuj obiekt typu Student

```http
  PUT /api/departments/{departmentId}/groups/{groupId}/students/{id}
```
| Parametr | Typ     | Opis                       |
| :-------- | :------- | :-------------------------------- |
| `departmentId`      | `int` | **Wymagane**. Id wydziału |
| `groupId`           | `int` | **Wymagane**. Id grupy |
| `id`           | `int` | **Wymagane**. Id studenta |

| Body      | Typ     | Opis                       |
| :-------- | :------- | :-------------------------------- |
| `UpdateStudentDto` | serialized json | **Wymagane**. Dane tworzonej grupy  |

#### Przykład body UpdateStudentDto
```yaml
{
   "FirstName": "Jan",
   "LastName": "Kowalski"
}
```

#### Usuń obiekt typu Student o podanym Id
```http
  DELETE /api/students/{id}
```

| Parametr | Typ     | Opis                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `int` | **Wymagane**. Id studenta |


### Marks:

#### Wyświetl wszystkie obiekty typu Mark:
```http
  GET /api/students/{studentId}/marks
```
| Parametr | Typ     | Opis                       |
| :-------- | :------- | :-------------------------------- |
| `studentId`      | `int` | **Wymagane**. Id studenta |


#### Wyświetl obiekt typu Mark o podanym Id
```http
  GET /api/students/{studentId}/marks/{id}
```

| Parametr | Typ     | Opis                       |
| :-------- | :------- | :-------------------------------- |
| `studentId`      | `int` | **Wymagane**. Id studenta |
| `id`      | `int` | **Wymagane**. Id oceny |


#### Dodaj obiekt typu Mark

```http
  POST /api/students/{studentId}/marks
```
| Parametr | Typ     | Opis                       |
| :-------- | :------- | :-------------------------------- |
| `studentId`      | `int` | **Wymagane**. Id studenta |


| Body      | Typ     | Opis                       |
| :-------- | :------- | :-------------------------------- |
| `CreateMarkDto` | serialized json | **Wymagane**. Dane tworzonej oceny  |

#### Przykład body CreateMarkDto
```yaml
{
   "DateOfIssue": "2022-01-01:14:42:34",
   "SubjectId": 41,
   "Description": "This is a mark!",
   "StudentId": 132412,
   "MarkValue": 5
}
```
#### Edytuj obiekt typu Mark

```http
  PUT /api/students/{studentId}/marks/{id}
```
| Parametr | Typ     | Opis                       |
| :-------- | :------- | :-------------------------------- |
| `studentId`      | `int` | **Wymagane**. Id studenta |
| `id`      | `int` | **Wymagane**. Id oceny |


| Body      | Typ     | Opis                       |
| :-------- | :------- | :-------------------------------- |
| `UpdateMarkDto` | serialized json | **Wymagane**. Dane tworzonej oceny  |

#### Przykład body UpdateMarkDto
```yaml
{
   "DateOfIssue": "2022-01-01:14:42:34",
   "SubjectId": 41,
   "Description": "This is a mark!",
   "StudentId": 132412,
   "MarkValue": 5
}
```
#### Usuń obiekt typu Mark o podanym Id
```http
  DELETE /api/students/{studentId}/marks/{id}
```

| Parametr | Typ     | Opis                       |
| :-------- | :------- | :-------------------------------- |
| `studentId`      | `int` | **Wymagane**. Id studenta |
| `id`      | `int` | **Wymagane**. Id oceny |
### Subjects:

#### Wyświetl wszystkie obiekty typu Subject:
```http
  GET /api/subjects
```


#### Wyświetl obiekt typu Subject o podanym Id
```http
  GET /api/subjects/{id}
```

| Parametr | Typ     | Opis                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `int` | **Wymagane**. Id przedmiotu |


#### Dodaj obiekt typu Subject

```http
  POST /api/subjects
```

| Body      | Typ     | Opis                       |
| :-------- | :------- | :-------------------------------- |
| `CreateSubjectDto` | serialized json | **Wymagane**. Dane tworzonego przedmiotu  |

#### Przykład body CreateSubjectDto
```yaml
{
   "Name": "Projekt zespołowy",
   "Description": "This is a subject",
   "StartTime": "2022-01-01:14:42:34",
   "EndTime": "2022-01-01:15:42:34",
   "WeekDaysId": 3,
   "ECTS": 4,
   "TeacherId": 5
}
```

#### Edytuj obiekt typu Subject

```http
  PUT /api/subjects
```

| Body      | Typ     | Opis                       |
| :-------- | :------- | :-------------------------------- |
| `UpdateSubjectDto` | serialized json | **Wymagane**. Dane tworzonego przedmiotu  |

#### Przykład body UpdateSubjectDto
```yaml
{
   "Name": "Projekt zespołowy",
   "Description": "This is a subject",
   "StartTime": "2022-01-01:14:42:34",
   "EndTime": "2022-01-01:15:42:34",
   "WeekDaysId": 3,
   "ECTS": 4,
   "TeacherId": 5
}
```

#### Usuń obiekt typu Subject o podanym Id
```http
  DELETE /api/subjects/{id}
```

| Parametr | Typ     | Opis                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `int` | **Wymagane**. Id przedmiotu |
