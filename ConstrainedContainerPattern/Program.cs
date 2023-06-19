BookContainer container = new BookContainer();

Book book1 = new Novel("Pride and Prejudice");
Book book2 = new ProfessionalBook("Clean Code");
Book book3 = new Magazine("National Geographic");

container.AddBook(book1);  // 可以成功添加
container.AddBook(book2);  // 可以成功添加
container.AddBook(book3);  // 無法添加，不符合限制

Book retrievedBook = container.GetBook();  // 可以成功獲取一本書
