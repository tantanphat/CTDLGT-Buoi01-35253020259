<<<<<<< HEAD
# BÀI THỰC HÀNH 01 – CẤU TRÚC DỮ LIỆU VÀ GIẢI THUẬT

## 1. Thông tin sinh viên

- **Họ tên:** Nguyễn Tấn Phát
- **MSSV:** 35253020259
- **Lớp học phần:** 26C1INF50900706

## 2. Hướng dẫn chạy chương trình

Yêu cầu: Đã cài đặt .NET SDK và Visual Studio Code.

1. Mở thư mục bài tập trong VS Code.
2. Mở Terminal bằng `Ctrl + Shift + ~`.
3. Nhập lệnh sau để chạy chương trình:

```bash
dotnet run
```

4. Nhập dữ liệu theo yêu cầu của từng bài và xem kết quả.

## 3. Mô tả giải pháp

### Bài 1: Nhập xuất và xử lý điều kiện

Nhập ba số nguyên, tìm số lớn nhất, nhỏ nhất, tính tổng và trung bình cộng.

### Bài 2: Hai giá trị lớn nhất phân biệt

Duyệt mảng một lần, sử dụng hai biến để lưu giá trị lớn nhất và lớn thứ hai phân biệt. Nếu không có giá trị lớn thứ hai, in `NO`.

### Bài 3: Đoạn con liên tiếp có tổng lớn nhất

- **Phiên bản A:** Sử dụng hai vòng lặp để tìm tổng lớn nhất của đoạn con liên tiếp.
- **Phiên bản B:** Sử dụng thuật toán Kadane để tìm tổng lớn nhất bằng một lần duyệt mảng.
- Sử dụng `Stopwatch` để đo thời gian chạy và so sánh hai thuật toán.

## 4. Độ phức tạp thuật toán

| Bài       | Thời gian | Bộ nhớ phụ |
| --------- | --------- | ---------- |
| Bài 1     | O(1)      | O(1)       |
| Bài 2     | Θ(n)      | Θ(1)       |
| Bài 3 – A | Θ(n²)     | Θ(1)       |
| Bài 3 – B | Θ(n)      | Θ(1)       |

## 5. Các test case đã sử dụng

### Bài 1

- `7 2 10`
- `-5 -2 -9`
- Các trường hợp có số trùng nhau và ba số bằng nhau.

### Bài 2

- `3 7 2 9 5` → Kết quả: `9` và `7`.
- `8 8 8 3` → Kết quả: `8` và `3`.
- `-9 -2 -5` → Kết quả: `-2` và `-5`.
- `4 4 4` → Kết quả: `NO`.

### Bài 3

- `-2 1 -3 4 -1 2 1 -5 4` → Tổng lớn nhất: `6`.
- `-8 -3 -6 -2 -5 -4` → Tổng lớn nhất: `-2`.
- `1 2 3` → Tổng lớn nhất: `6`.

Thực nghiệm Bài 3 với các kích thước mảng `100`, `1000` và `10000`.

## 6. Công cụ AI đã sử dụng

Tôi đã sử dụng ChatGPT để giải thích thuật toán, viết README, hỗ trợ xây dựng và kiểm tra mã nguồn. Tôi đã chạy thử chương trình và chịu trách nhiệm về kết quả nộp bài.
=======
# CTDLGT-Buoi01-35253020259
>>>>>>> dedfd617473d68b4e11b177680d4c9da9e8e2bf5
