using System.Drawing;
using Emgu.CV;
using Emgu.CV.Structure;

Console.WriteLine("Введите путь до файла .jpg");

var path = Console.ReadLine();
var image = new Image<Bgr, byte>(path);

var classifier = new CascadeClassifier("haarcascade_plate_number.xml");
var faces = classifier.DetectMultiScale(image);

foreach (var face in faces)
{
    image.Draw(face, new Bgr(Color.Red), 2);
}

Console.WriteLine("Изображение сохранено в \"number.jpg\"");
image.Save("number.jpg");
