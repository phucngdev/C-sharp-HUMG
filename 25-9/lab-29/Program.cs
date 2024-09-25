using System;
using System.IO;
using System.Text;
namespace Humg_25_9_lab_29 {
  public class UtilsEncoding {
    string filepath = "data.dat";
    using var stream = new FileStream(path:filepath, mode: FileMode.Open, access: FileAccess.Read, share: FileShare.Read)
    byte[] BOMBytes = {1, 2, 3, 4};
    int offset = 0; // vị trí (index) trong buffer - nơi ghi byte đầu tiên đọc được
    int count = 4; // đọc 4 byte
    int numberbyte = stream.Read (BOMBytes, offset, count); // bắt đầu đọc 4 đầu tiên lưu vào buffer
  }

}