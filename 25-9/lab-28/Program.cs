using System;
using System.IO;
namespace Humg_25_9_lab_28 {
    public class GetDriveInfomation {
       
        public static void Main(string []args) {
            DriveInfo[] allDrives = DriveInfo.GetDrives (); // lấy tất cả các ổ trong máy
            foreach (DriveInfo d in allDrives) {
                Console.WriteLine ("Drive {0}", d.Name);
                Console.WriteLine ("Drive type: {0}", d.DriveType);
                if (d.IsReady == true) {
                    Console.WriteLine ("Volume label: {0}", d.VolumeLabel);
                    Console.WriteLine ("File system: {0}", d.DriveFormat);
                    Console.WriteLine ("Available space to current user:{0, 15} bytes", d.AvailableFreeSpace);
                    Console.WriteLine ("Total available space:          {0, 15} bytes", d.TotalFreeSpace);
                    Console.WriteLine ("Total size of drive:            {0, 15} bytes ", d.TotalSize);
                }
            }

            // lấy tất cả các file trong 1 thư mục
            string[] files = Directory.GetFiles ("obj");
            Console.WriteLine ("\nFiles in directory obj:");
            foreach (string file in files) {
                Console.WriteLine (file);
            }

            
        }
    }
}