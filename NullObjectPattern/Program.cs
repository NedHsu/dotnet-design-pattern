// 使用範例
MusicPlayer player = new MusicPlayer();

// 播放選擇的歌曲
ISong song1 = new Song("Song 1", "Artist 1");
player.SetSong(song1);
player.Play();

// 停止播放
player.Stop();

// 沒有選擇歌曲時，使用空歌曲物件
ISong nullSong = new NullSong();
player.SetSong(nullSong);
player.Play(); // 輸出：No song selected
player.Stop(); // 輸出：No song selected
