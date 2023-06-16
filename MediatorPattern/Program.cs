// 使用範例
IChatMediator chatMediator = new ChatRoomMediator();

Colleague webClient1 = new WebClientColleague(chatMediator, "WebClient1");
Colleague webClient2 = new WebClientColleague(chatMediator, "WebClient2");
Colleague mobileClient1 = new MobileClientColleague(chatMediator, "MobileClient1");

chatMediator.AddColleague(webClient1);
chatMediator.AddColleague(webClient2);
chatMediator.AddColleague(mobileClient1);

webClient1.Send("Hello, everyone!");
mobileClient1.Send("Hi, guys!");

// 輸出:
// Web Client [WebClient1] sends message: Hello, everyone!
// Web Client [WebClient2] receives message: Hello, everyone!
// Mobile Client [MobileClient1] sends message: Hi, guys!
// Web Client [WebClient1] receives message: Hi, guys!
// Web Client [WebClient2] receives message: Hi, guys!
