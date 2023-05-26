# ManagerMusic
Hệ thống quản lý file bài hát và cho người dùng
+ Đây là full dự án ManagerMusic
- Có phần code cho front-end
- Có phần code cho back-end
- Các công nghệ được dùng chủ yếu Asp.net core, CoreFirst, Ajax, Html, Css, Javascript, Jquery


------------------------------------------------------------------------------------------------
CÁC HÀM NÊN DÙNG ĐỂ CẢI THIỆN TỐC ĐỘ XỬ LÝ CỦA ỨNG DỤNG KHI TRUY VẤN DATABASE
- khác nhau giữa Any() và Count() trong LinQ
- Any() sẻ trả về giá trị bool, Count() sẻ trả về giá trị int
- Any() chỉ cần tìm thấy phần tử đầu tiên trong mảng thỏa điều kiện là trả về kết quả
- Count() thì lặp qua từng phần tử rồi trả về tổng số
- Nên trong trường hợp chỉ cần kiểm tra list có null hay không ta nên dùng Any() sẻ trả về kết quả với thời gian nhanh hơn.

-----------------------------------------------------------------------------------------------
- Trùng dữ liệu 2 mã Id City 8 và 30 (Lâm Đồng) -> dùng mã  30 là cho lâm đồng


--------------------------------------------------------------------------------------------------
TÌNH HÌNH TIẾN ĐỘ CÔNG VIỆC CHỨC NĂNG
21/4/2023
- Thêm mới forder import city, district, country -> excel file
08/5/2023
- Hoàn thành chức năng xóa Tỉnh/Tp trong Detail City - xóa luôn các District có liên quan đến tỉnh đó