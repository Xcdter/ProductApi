# ProductApi

## Описание
Проект представляет собой веб приложение с RESTful Api для управления товарами и категориями товаров, реализованный на C# с использованием ASP.NET Core и Entity Framework Core.

## Стек технологий
- .Net 8.0 (или последняя стабильная версия)
- ASP.NET Core
- Entity Framework Core
- InMemory

## Установка

### Требования
- .NET SDK 8.0 или выше
- IDE (например, Visual Studio 2022)

### Клонирование репозитория
```bash
git clone https://github.com/Xcdter/ProductApi.git
cd ProductApi
```
### Усиановка зависимостей
```bash
dotnet restore
```


Запуск приложения
```bash
dotnet run
```


API будет доступно по адрессу
```bash
http://localhost:5000
```

## Использование API

### Эндпоинты

#### Категории товаров
- GET /api/RroductCategories - Получить все категории
- GET /api/RroductCategories/{id} - Получить категорию по ID
- POST /api/RroductCategories - Создать новую категорию
- PUT /api/RroductCategories/{id} - Обновить категорию
- DELETE /api/RroductCategories/{id} - Удалить категорию

#### Товары
- GET /api/Products - Получить все товары
- GET /api/Products/{id} - Получить товар по ID
- POST /api/Products - Создать новый товар
- PUT /api/Products/{id} - Обновить товар
- DELETE /api/Products/{id} - Удалить товар

## Обработка ошибок
Все возможные ошибки обрабатываются с соответствующими HTTP-кодами ответа.

## Дополнительные возможности
Валидация входных данных при создании и обновлении сущностей.
