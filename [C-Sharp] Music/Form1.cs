using System;
using System.Windows.Forms;

namespace _C_Sharp__Music
{
    public partial class Form1 : Form
    {
        public Form1()
        { InitializeComponent(); }

        String[] files, paths; //пути и папки.
        Boolean play_F = true; //флаг корректного отображения и работы кнопки play/pause

        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer(); // библиотека Windows.MediaPlayer.dll

        //1. Выбор музыки 
        private void import_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog Select_Music = new OpenFileDialog();
            Select_Music.Multiselect = true; //true - возможность выбрать несколько файлов
            Select_Music.Filter = "Music |*.mp3;*.wav|All files |*.*"; //фильтры допустимых форматов
            Select_Music.InitialDirectory = "C:\\Users\\Public\\Music"; //директория по-умолчанию

            if (Select_Music.ShowDialog() == DialogResult.OK)
                try
                {
                    files = Select_Music.SafeFileNames; //сохранение названий папки и музыки
                    paths = Select_Music.FileNames; //путь к музыке (разница в том, что один с Safe, другой - без)
                    for (int i = 0; i < files.Length; i++) //отображение музыки или плейлиста
                        Songs.Items.Add(files[i]);
                }
                catch
                {
                    //ну мало-ли, кто додумается *.jpeg открыть
                    MessageBox.Show("File open error", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        //2. Проигрывать (приостановить) музыку, через указатели в ListBox
        private void playPause_button_Click(object sender, EventArgs e)
        {
            if (Songs.Items.Count < 1)
                MessageBox.Show("No music in playlist", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                //если со старта программы не было выбрано ни одного трека
                //воспроизведение можно начать с начала списка кнопкой play
                if (Songs.SelectedIndex < 0)
                {
                    player.URL = paths[0];
                    Songs.SelectedIndex = 0;
                }

                if (play_F)
                {
                    player.controls.play();
                    playPause_button.BackgroundImage = global::_C_Sharp__Music.Properties.Resources.pause_button;
                }
                if (!play_F)
                {
                    player.controls.pause();
                    playPause_button.BackgroundImage = global::_C_Sharp__Music.Properties.Resources.play_button;
                }
                play_F = !play_F;
            }
        }

        //3. Полностью остановить музыку 
        private void stop_button_Click(object sender, EventArgs e)
        {
            if (Songs.Items.Count < 1)
                MessageBox.Show("No music in playlist", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                player.controls.stop();

                //анимация и корректная работа кнопки play (далее такие-же записи аналогично)
                if (!play_F)
                {
                    playPause_button.BackgroundImage = global::_C_Sharp__Music.Properties.Resources.play_button;
                    play_F = !play_F;
                }
            }
        }

        //4. Выбрать предыдущий трек
        private void previous_button_Click(object sender, EventArgs e)
        {
            if (Songs.Items.Count < 1)
                MessageBox.Show("No music in playlist", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (Songs.SelectedIndex > 0)
            {
                player.URL = paths[Songs.SelectedIndex - 1];
                Songs.SelectedIndex = Songs.SelectedIndex - 1;

                if (play_F)
                {
                    playPause_button.BackgroundImage = global::_C_Sharp__Music.Properties.Resources.pause_button;
                    play_F = !play_F;
                }
            }
        }

        //5. Выбрать следующий трек
        private void next_button_Click(object sender, EventArgs e)
        {
            if (Songs.Items.Count < 1)
                MessageBox.Show("No music in playlist", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (Songs.SelectedIndex < files.Length - 1)
            {
                player.URL = paths[Songs.SelectedIndex + 1];
                Songs.SelectedIndex = Songs.SelectedIndex + 1;
                if (play_F)
                {
                    playPause_button.BackgroundImage = global::_C_Sharp__Music.Properties.Resources.pause_button;
                    play_F = !play_F;
                }
            }
        }
        private void Songs_SelectedIndexChanged(object sender, EventArgs e)
        { 
            player.URL = paths[Songs.SelectedIndex];
        }

        //Обработчики анимации кнопок
        private void playPause_button_MouseDown(object sender, MouseEventArgs e)
        {
            if (play_F)
                playPause_button.BackgroundImage = global::_C_Sharp__Music.Properties.Resources.play_button_pressed;
            if (!play_F)
                playPause_button.BackgroundImage = global::_C_Sharp__Music.Properties.Resources.pause_button_pressed;
        }
        private void playPause_button_MouseUp(object sender, MouseEventArgs e)
        {
            if (play_F)
                playPause_button.BackgroundImage = global::_C_Sharp__Music.Properties.Resources.play_button;
            if (!play_F)
                playPause_button.BackgroundImage = global::_C_Sharp__Music.Properties.Resources.pause_button;
        }

        private void previous_button_MouseDown(object sender, MouseEventArgs e)
        {
            previous_button.BackgroundImage = global::_C_Sharp__Music.Properties.Resources.prew_button_pressed;
        }
        private void previous_button_MouseUp(object sender, MouseEventArgs e)
        {
            previous_button.BackgroundImage = global::_C_Sharp__Music.Properties.Resources.prew_button;
        }

        private void stop_button_MouseDown(object sender, MouseEventArgs e)
        {
            stop_button.BackgroundImage = global::_C_Sharp__Music.Properties.Resources.stop_button_pressed;
        }
        private void stop_button_MouseUp(object sender, MouseEventArgs e)
        {
            stop_button.BackgroundImage = global::_C_Sharp__Music.Properties.Resources.stop_button;
        }

        private void next_button_MouseDown(object sender, MouseEventArgs e)
        {
            next_button.BackgroundImage = global::_C_Sharp__Music.Properties.Resources.next_button_pressed;
        }
        private void next_button_MouseUp(object sender, MouseEventArgs e)
        {
            next_button.BackgroundImage = global::_C_Sharp__Music.Properties.Resources.next_button;
        }

        private void import_button_MouseDown(object sender, MouseEventArgs e)
        {
            import_button.BackgroundImage = global::_C_Sharp__Music.Properties.Resources.import_button_pressed;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            player.settings.volume = player.settings.volume + 10;
        }

        private void Form1_Load(object sender, EventArgs e) //в начале будет 
        {
            player.settings.volume = 50;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player.settings.volume = player.settings.volume - 10;
        }

        private void import_button_MouseUp(object sender, MouseEventArgs e)
        {
            import_button.BackgroundImage = global::_C_Sharp__Music.Properties.Resources.import_button;
        }
    }
}

/*
   ####### #######    ##   #######  ###   ##   ######     ######
   ##      ###  ###   ##   ###      ###   ##   ##   ###  ###  ###
   ##      ###   ##   ##   ###      ####  ##   ##   ###  ###
   ##      ###   ##   ##   ###      ## #  ##   ##   ###   ###
   ######  ########   ##   ######   ## ## ##   ##   ###    ####
   ##      #######    ##   ###      ##  ####   ##   ###      ###
   ##      ###  ##    ##   ###      ##  ####   ##   ###       ###  
   ##      ###   ##   ##   ###      ##   ###   ##   ###  ###  ### 
   ##      ###   ##   ##   #######  ##.  ###   ######     ######
  
                                              ``                             
                              `.              `ys                            
                              +h+             +yh-                           
                              yyh:           .hyys                           
                             .hyyh.          oyyyh`                          
                             /yyyyy`        .hyydy/                          
                             syyhhy+        oyyhsys                          
                             hyyyoyh.      .hyyy:hh`                         
                            .hyyyy:ho      +yyys-yh-                         
                            :hyyyh-oh.    `hyyyo-oy/                         
                            /yyyyh-:h+    -hyyh/-oy+                         
                            +yyyyh:-yy    +yyyh--oyo                         
                            +yyyyh/-sh.   syyyh--oyo                         
                            +yyyyh/-oy/  `hyyyy--syo                         
                            +yyyyh/-+y+  `hyyys--yy+                         
                            :yyyyh/-+ys  .hyyyo-:hy:                         
                            .hyyyh+-+ys  .hyyyo-oyh`                         
                            `yyyyyo-oyy  .hyyy+-yyy                          
                             +yyyys-syy  `hyyh/oyy/                          
                             .hyyyh-hyy  `hyyh/hyh`                          
                              oyyyhshys   yyyhyyy+                           
                              oyyyhshys   yyyhyyy+                           
                               /hyyyyyo`.-oyyyyh/                            
                               `syyyyyyyhyyyyyyho.                           
                                .hyyyyhNdyyyyyyymh/`                          
        
  

*/