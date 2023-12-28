 use SQLquanly
go
CREATE TABLE ANSWER (
    AnswerID INT PRIMARY KEY,
    Answer NCHAR(MAX),
);
INSERT INTO ANSWER (AnswerID, Answer) VALUES
(1, N'Để đặt vé bạn cần phải đăng nhập tài khoản của bạn. 
    Để Đăng Nhập : 
1. ở giao diện lúc mới vào tại bên trái màn hình có nút đăng nhập và đăng ký hãy bấm vào đó và đăng nhập.
    Để Đăng Ký : 
2. nếu bạn chưa có tài khoản hãy bấm vào đăng ký và điền thông tin cuối cùng là đăng ký.
    Đặt Vé :  
3. sau khi đăng ký thành công quay lại đăng nhập, đăng hập xong hãy bấm vào nút đặt vé, ở bên phải nút đặt vé có tất cả thông tin của các chuyến bay, hãy tra và chọn mã chuyến bay và chọn loại vé, chọn loại thnah toán và bấm đặt vé, cuối cùng bạn hãy đến quầy bán vé tai nơi bán vé để nhận vé'),
(2, N'Khi đi máy bay, có một số vấn đề có thể sảy ra, và dưới đây là một số ví dụ:

1. Chậm trễ hoặc hủy chuyến bay: Thời tiết xấu, sự cố kỹ thuật, hoặc các vấn đề khác có thể gây chậm trễ hoặc hủy bỏ chuyến bay của bạn.

2. Mất hành lý hoặc hành lý bị hỏng: Hành lý của bạn có thể bị mất hoặc hỏng trong quá trình vận chuyển.

3. Không có chỗ ngồi cạnh nhau: Nếu bạn đi cùng với gia đình hoặc bạn bè, có thể xảy ra tình trạng không có chỗ ngồi cạnh nhau nếu bạn không đặt chỗ trước.

4. Rủi ro về sức kháng cản: Trong một số trường hợp, việc bay có thể gây ra sự kháng cản cho sức khỏe của bạn, chẳng hạn như tăng áp suất trong môi trường phi hành tinh và thay đổi độ ẩm.

5. Vấn đề về an ninh: Các biện pháp an ninh nghiêm ngặt có thể gây ra sự bất tiện cho hành khách, chẳng hạn như kiểm tra an ninh nhiều lần hoặc kiểm tra hành lý.

6. Chứng thực hành khách: Nếu bạn không có giấy tờ chứng thực hợp lệ hoặc visa cần thiết, bạn có thể bị từ chối lên máy bay hoặc nhập cảnh ở điểm đến.

7. Sự cố y tế: Một số hành khách có thể trải qua sự cố y tế khi đi máy bay, và máy bay phải hạ cánh để cấp cứu trong trường hợp cần thiết.

8. Thất thoát tài sản cá nhân: Do quên mất hoặc để lại đồ trong máy bay hoặc sân bay.

9. Không thoải mái hoặc không phục vụ tốt: Một số hành khách có thể phàn nàn về không gian hẹp, thức ăn kém chất lượng hoặc phục vụ không tốt trên máy bay.

10. Thời tiết xấu trong quá trình bay: Turbulence (sự rung lắc) có thể gây ra cảm giác không thoải mái và buồn nôn cho một số hành khách.

11. Không kích hoạt phát hiện máy bay: Máy bay có thể bị mất tích hoặc bị tai nạn, dẫn đến nguy cơ mất tích hoặc tai nạn hàng không.

Để giảm thiểu các vấn đề này, hãy kiểm tra thông tin chuyến bay trước, đến sân bay đúng giờ, đảm bảo giấy tờ và visa hợp lệ, đặt chỗ trước nếu cần, và tuân thủ các quy tắc an toàn và hướng dẫn của hãng hàng không.'),
(3, N'Để đảm bảo chuyến bay của bạn an toàn, hãy tuân theo các nguyên tắc sau:

1. Kiểm tra thông tin chuyến bay: Trước khi đi, kiểm tra thông tin về chuyến bay của bạn. Xác định thời gian cất cánh, địa điểm lên máy bay, và cách đến sân bay.

2. Kiểm tra giấy tờ và visa: Đảm bảo bạn có giấy tờ chứng thực, hộ chiếu, visa (nếu cần) và các tài liệu liên quan khác.

3. Sử dụng hãng hàng không đáng tin cậy: Chọn một hãng hàng không có lịch sử an toàn tốt và được đánh giá cao.

4. Tuân thủ quy tắc an toàn của hãng hàng không: Nghe lời hướng dẫn của phi hành đoàn và tuân thủ quy tắc an toàn của hãng hàng không, bao gồm việc thắt dây an toàn và tắt chế độ máy bay trong khi cất cánh và hạ cánh.

5. Đặt chỗ trước: Đặt chỗ trước để đảm bảo bạn có chỗ ngồi ưa thích và có thể ngồi cùng với gia đình hoặc bạn bè nếu cần.

6. Tránh thời tiết xấu: Theo dõi thông tin thời tiết và tránh chọn chuyến bay trong điều kiện thời tiết xấu, đặc biệt là trong trường hợp bão, tuyết rơi dày đặc, hoặc bão giông mạnh.

7. Tránh sử dụng các hãng hàng không bất thường: Tránh sử dụng các hãng hàng không không rõ nguồn gốc hoặc không được kiểm tra an toàn đầy đủ.

8. Tuân thủ các quy định về hành lý cầm tay: Kiểm tra và tuân thủ các quy định về hành lý cầm tay, bao gồm các loại chất cấm.

9. Sử dụng dây an toàn trong xe buýt chở đến máy bay: Nếu bạn phải sử dụng xe buýt để đến máy bay, hãy thắt dây an toàn khi có sẵn.

10. Kiểm tra tình trạng sức khỏe của bạn: Nếu bạn có vấn đề về sức khỏe, hãy thảo luận với bác sĩ trước khi bay, đặc biệt là nếu bạn có tiền sử về các vấn đề như tim mạch hay bệnh phổi.

11. Tránh sử dụng chất gây ảnh hưởng: Tránh sử dụng chất gây ảnh hưởng như rượu hoặc thuốc lá trước và trong suốt chuyến bay.

12. Thận trọng khi mang theo đồ cá nhân: Đặc biệt là với các vật phẩm như hóa chất, dụng cụ sắc nhọn, hoặc các đồ vật có thể gây hại.

Tuân thủ những nguyên tắc này sẽ giúp tăng cường an toàn trong chuyến bay của bạn.'),
(4,N'Trước khi tham gia chuyến bay, có một số thủ tục quan trọng bạn cần thực hiện để đảm bảo sự suôn sẻ và an toàn của hành trình. Dưới đây là danh sách các thủ tục cơ bản:

1. Đặt vé máy bay: Đầu tiên, bạn cần đặt vé máy bay qua trang web của hãng hàng không hoặc qua đại lý du lịch. Sau khi đặt vé, bạn sẽ nhận được một mã đặt chỗ hoặc vé điện tử.

3. Xác minh thông tin chuyến bay: Trước ngày khởi hành, hãy kiểm tra thông tin về chuyến bay của bạn như ngày, giờ, và sân bay xuất phát. Thường xuyên kiểm tra để đảm bảo không có thay đổi.

4. Làm thủ tục đăng ký (check-in): Bạn có thể làm thủ tục đăng ký trực tuyến qua trang web của hãng hàng không hoặc tại quầy làm thủ tục ở sân bay. Thủ tục này bao gồm xác minh thông tin hành khách và nhận thẻ lên máy bay (boarding pass).

5 Kiểm tra hành lý: Đảm bảo bạn đã đóng gói hành lý một cách an toàn và tuân thủ quy định về kích thước và trọng lượng hành lý. Nếu cần, bạn có thể mua dịch vụ hành lý thêm (extra baggage) trước khi lên máy bay.

6. Xác minh giấy tờ cá nhân: Điều này bao gồm việc kiểm tra hạn sử dụng của hộ chiếu hoặc giấy tờ tùy thân khác và đảm bảo chúng vẫn còn hiệu lực. Nếu bạn đi quốc tế, kiểm tra xem bạn có cần thị thực (visa) không.

7. An ninh sân bay: Tại sân bay, bạn sẽ phải trải qua các thủ tục an ninh bao gồm kiểm tra hành lý xách tay, qua máy quét an ninh, và kiểm tra giấy tờ. Điều này có thể mất một thời gian, vì vậy hãy đến sân bay sớm để tránh trễ chuyến bay.

8. Điều kiện sức khỏe: Đảm bảo bạn đủ sức khỏe để bay. Nếu bạn có bất kỳ triệu chứng bệnh hoặc tiếp xúc gần với người mắc bệnh nhiễm trùng, hãy xem xét hoãn chuyến bay và tham khảo ý kiến bác sĩ.

9. Chuẩn bị tài liệu quan trọng: Đảm bảo bạn mang theo giấy tờ quan trọng như vé máy bay, hộ chiếu (hoặc giấy tờ tùy thân), thẻ lên máy bay, và bất kỳ giấy tờ quan trọng khác như thị thực (nếu cần).

10. Săn sóc đặc biệt: Nếu bạn cần dịch vụ đặc biệt như hỗ trợ cho người khuyết tật hoặc dịch vụ trẻ em một mình, hãy thông báo cho hãng hàng không trước khi chuyến bay.

11. Theo dõi thông tin chuyến bay: Theo dõi tình hình chuyến bay của bạn, đặc biệt là trong trường hợp có thay đổi hoặc hủy bỏ. Hãng hàng không thường thông báo qua email hoặc tin nhắn về điện thoại.

Hãy chắc chắn thực hiện các thủ tục này trước khi tham gia chuyến bay để đảm bảo một hành trình thuận lợi và không gặp sự cố nào không cần thiết.');

