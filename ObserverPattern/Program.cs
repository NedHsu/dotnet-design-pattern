Newspaper newspaper = new Newspaper();
Reader reader1 = new Reader("John");
Reader reader2 = new Reader("Alice");

newspaper.Register(reader1);
newspaper.Register(reader2);

newspaper.PublishNews("Breaking News: COVID-19 vaccine approved!");

newspaper.Unregister(reader2);

newspaper.PublishNews("Sports: Home team wins the championship!");

// 輸出:
// Reader John received news: Breaking News: COVID-19 vaccine approved!
// Reader Alice received news: Breaking News: COVID-19 vaccine approved!
// Reader John received news: Sports: Home team wins the championship!
