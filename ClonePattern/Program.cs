// 使用範例
House originalHouse = new House("123 Main St", 3);
originalHouse.PrintDetails(); // 輸出：Address: 123 Main St, Rooms: 3

// 複製房屋
House clonedHouse = (House)originalHouse.Clone();
clonedHouse.Address = "456 Elm St";
clonedHouse.NumberOfRooms = 4;

clonedHouse.PrintDetails(); // 輸出：Address: 456 Elm St, Rooms: 4
originalHouse.PrintDetails(); // 輸出：Address: 123 Main St, Rooms: 3
