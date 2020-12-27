using System;
using Tizen.NUI;
using Tizen.NUI.BaseComponents;
using Tizen.Applications;
using System.IO;

namespace ShowAnim
{
    class Program : NUIApplication
    {
        public static readonly string photoName_1 = Application.Current.DirectoryInfo.SharedResource + "1.jpg";
        public static readonly string photoName_2 = Application.Current.DirectoryInfo.SharedResource + "2.jpg";

        public ImageView photoView_1 = null;
        public ImageView photoView_2 = null;

        public bool changePhotoFlag = true;


        protected override void OnCreate()
        {
            base.OnCreate();
            Initialize();
        }

        void Initialize()
        {
            Window.Instance.KeyEvent += OnKeyEvent;

            //TextLabel text = new TextLabel("Hello Tizen NUI World");
            //text.HorizontalAlignment = HorizontalAlignment.Center;
            //text.VerticalAlignment = VerticalAlignment.Center;
            //text.TextColor = Color.Blue;
            //text.PointSize = 30.0f;
            //text.HeightResizePolicy = ResizePolicyType.FillToParent;
            //text.WidthResizePolicy = ResizePolicyType.FillToParent;
            //Window.Instance.GetDefaultLayer().Add(text);

            //Animation animation = new Animation(2000);
            //animation.AnimateTo(text, "Orientation", new Rotation(new Radian(new Degree(180.0f)), PositionAxis.X), 0, 500);
            //animation.AnimateTo(text, "Orientation", new Rotation(new Radian(new Degree(0.0f)), PositionAxis.X), 500, 1000);
            //animation.Looping = true;
            //animation.Play();

            View mainView = new View();
            mainView.Position2D = new Position2D(0, 0);
            mainView.Size2D = new Size2D(1920, 1080);
            mainView.BackgroundColor = Color.Blue;


            
            photoView_1 = new ImageView();
            photoView_1.Position2D.X = 160;
            photoView_1.Position2D.Y = 60;
            photoView_1.Size2D.Height = 960;
            photoView_1.Size2D.Width = 640;
            photoView_1.ResourceUrl = Application.Current.DirectoryInfo.SharedResource + "1.jpg";


            photoView_2 = new ImageView();           
            photoView_2.Position2D.X = 1120;
            photoView_2.Position2D.Y = 60;
            photoView_2.Size2D.Height = 960;
            photoView_2.Size2D.Width = 640;
            photoView_2.ResourceUrl = Application.Current.DirectoryInfo.SharedResource + "2.jpg";


            photoView_1.Show();
            Window.Instance.GetDefaultLayer().Add(mainView);

            mainView.Add(photoView_1);
            mainView.Add(photoView_2);

            CreatePhoto1Animation();

        }

        public void OnKeyEvent(object sender, Window.KeyEventArgs e)
        {
            if (e.Key.State == Key.StateType.Down && (e.Key.KeyPressedName == "XF86Back" || e.Key.KeyPressedName == "Escape"))
            {
                Exit();
            }


        }

        static void Main(string[] args)
        {
            var app = new Program();
            app.Run(args);
        }

        public void CreatePhoto1Animation()
        {
            Animation animation = new Animation(2000);
            animation.AnimateTo(photoView_1, "Orientation", new Rotation(new Radian(new Degree(180.0f)), PositionAxis.Y), 0, 1000);
            animation.AnimateTo(photoView_1, "Orientation", new Rotation(new Radian(new Degree(360.0f)), PositionAxis.Y), 1000, 2000);

            animation.AnimateTo(photoView_2, "Orientation", new Rotation(new Radian(new Degree(180.0f)), PositionAxis.Y), 0, 1000);
            animation.AnimateTo(photoView_2, "Orientation", new Rotation(new Radian(new Degree(360.0f)), PositionAxis.Y), 1000, 2000);

            animation.AnimateTo(photoView_2, "Orientation", new Rotation(new Radian(new Degree(180.0f)), PositionAxis.Z), 0, 1000);
            animation.AnimateTo(photoView_2, "Orientation", new Rotation(new Radian(new Degree(360.0f)), PositionAxis.Z), 1000, 2000);

            animation.Looping = true;
            animation.Play();
        }
    }
}
