using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib; //Âm thanh sử dụng Loa trong = có sẵn của PC
using AxWMPLib; //Âm thanh sử dụng Loa Ngoài = lắp vào PC = Aux...
using System.IO; //Xử lý file âm thanh


namespace A07PALSOS
{
    public partial class frPAL2WMP : Form
    {

        string audiopath = Path.GetDirectoryName(Path.GetDirectoryName(Application.StartupPath)) + "\\FileAmThanh\\"; 
        //LẤY THƯ MỤC HIỆN TẠI (PATH) CỦA APP
        //Application.StartupPath = đường dẫn thư mục App \bin\Debug => để path của App lấy ra ngoài thư mục cha 2 lần

        /// <summary>
        /// Hàm thiết lập = KHÔNG ĐƯỢC XÓA BẰNG MỌI GIÁ & ĐÚNG TÊN CLASS FORM PHÍA TRÊN // CÙNG namespace trùng với tên project
        /// </summary>
        public frPAL2WMP()
        {
            InitializeComponent();
        }
        /// <summary>
        /// FORM LOAD = TỰ CHẠY THỦ TỤC NÀY, MỖI KHI FORM NÀY ĐƯỢC LOAD [MỞ] LÊN
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void frPAL2WMP_Load(object sender, EventArgs e)
        {
            try
            {
                this.aUDIOFILESTableAdapter.Fill(this.a07PALSOSDataSet.AUDIOFILES);
            }
            catch (System.Exception ex) { MessageBox.Show("Lỗi nạp dữ lệu các files âm thanh " + ex.Message); }
        }
        /// <summary>
        /// CLOSE FORM NÀY => MH CHÍNH
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClose_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Thiệt là muốn đóng màn hình này. về màn hình chính (Y/N)", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                this.Close();
            }
        }//close

        /// <summary>
        /// THOÁT APP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Có thật sự là muốn thoát chương trình này hay không (Y/N)", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                Application.Exit();//thoát chương trình
            }
        }//exit

        /// <summary>
        /// LẬP TRÌNH THAO TÁC XỬ LÝ ÂM THANH 
        /// </summary>
        
        //Play = CHẠY FILE AUDIO FILES
        private void btnPlay_Click(object sender, EventArgs e)
        {
            axWMP.Ctlcontrols.play();//phát âm thanh
        }
        // Tạm dừng (pause) audio file hiện đang play trên WMP
        private void btnPause_Click(object sender, EventArgs e)
        {
            axWMP.Ctlcontrols.pause(); // tạm dừng (pause) audio file hiện đang play trên WMP
        }
        // Dừng (stop) audio file hiện đang play trên WMP
        private void BtnStop_Click(object sender, EventArgs e)
        {
            axWMP.Ctlcontrols.stop();// Dừng (Stop) audio file hiện đang play trên WMP
        }
        // Chạy nhanh (fast forward) audio file hiện đang play trên WMP
        private void BtnFast_Click(object sender, EventArgs e)
        {
            axWMP.Ctlcontrols.fastForward();
        }
        // Chạy ngược lại audio file hiện đang play trên WMP
        private void BtnSlow_Click(object sender, EventArgs e)
        {
            axWMP.Ctlcontrols.fastReverse();
        }
        //VỀ TRACK ĐẦU TIÊN
        private void BtnFirst_Click(object sender, EventArgs e)
        {
            listBoxAuFile.SelectedIndex = 0;
        }
        //CHẠY TRACK KẾ TRƯỚC; NẾU TRACK ĐẦU TIÊN => VỀ TRACK CUỐI
        private void BtnPrev_Click(object sender, EventArgs e)
        {
            if (listBoxAuFile.SelectedIndex > 0) listBoxAuFile.SelectedIndex--;
            //Nếu chưa phải là Track ĐẦU ( > 0)  thì GIẢM vị trí Track XUỐNG 1 (--) đến Track kế TRƯỚC
            else listBoxAuFile.SelectedIndex = listBoxAuFile.Items.Count - 1; 
            //nếu đang là Track ĐẦU (0) thì chuyển XUỐNG Track CUỐI CÙNG (vi trí vị trí cuối: count -1)            
        }
        //CHẠY TRACK KẾ TIẾP; NẾU TRACK CUỐI => VỀ TRACK ĐẦU
        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (listBoxAuFile.SelectedIndex < listBoxAuFile.Items.Count - 1)
                listBoxAuFile.SelectedIndex++; 
            //Nếu chưa phải là Track cuối ( < vị trí cuối: count -1)  thì tăng vị trí Track lên 1(++) đến Track kế tiếp
            else listBoxAuFile.SelectedIndex = 0; //nếu đang là Track cuối (count - 1) thì chuyển về Track đầu tiên(vi trí 0)
        }
        //XUỐNG TRACK  CUỐI CÙNG
        private void BtnLast_Click(object sender, EventArgs e)
        {
            listBoxAuFile.SelectedIndex = listBoxAuFile.Items.Count - 1;
        }

        /// <summary>
        /// LẬP TRÌNH THAO TÁC quản lý các files âm thanh
        /// </summary>
        
        static DialogResult ch = DialogResult.No;
        //BIẾN TOÀN CỤC Giữ nút lệnh NSD đã chọn;khi Chọn file âm thanh dùng OpenFileDialog:
        //Y = đồng ý chọn file, N = ko đồng ý(sẽ chọn lại, hoặc ko chọn)
        //bắt buộc static = Sau khi ra khỏi thủ tục vẫn giữ lại giá trị KO bị hủy vùng nhó

        /// <summary>
        /// NẠP THÊM FILE ÂM THANH
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            //B1:Cho || cấm các nút lệnh các khác và một số textbox liên quan thông tin file âm thanh mà NSD tự nhập (mã số, mô tả) 
            txtMaSo.Enabled = !txtMaSo.Enabled;
            txtDesc.Enabled = !txtDesc.Enabled;
            BtnModify.Enabled = !BtnModify.Enabled;
            BtnRecord.Enabled = !BtnRecord.Enabled;
            BtnDelete.Enabled = !BtnDelete.Enabled;

            //B2: ĐỔI NHÃN (.TEXT) CỦA NÚT LỆNH : "Nạp..." <-> "Lưu..."
            if (BtnLoad.Text == "Nạp file mới")
            //bắt đầu nập file âm thanh = NSD chọn file & nập thông tin ["Nạp thêm files" copy từ Design sang, KHÔNG tự  nhập]
            {//Mở OpenFilesDialog lên cho NSD chọn file âm thanh / PC
                ch = openFileDialog1.ShowDialog();
                //biến toàn cục ch đã khai báo phía trên, giữ lại nút lệnh (Y|N) mà NSD đã chọn để xử lý trong ...else..  
                txtMaSo.Text = "Quý vị phải nhập mã số file vào đây";
                txtDesc.Text = ""; // Xóa thống để NSD nhập mlo6 tả mới
                BtnLoad.Text = "Lưu file âm thanh"; //Đổi nhãn (.Text) thahh2 "Lưu...": tự nhập
            }
            else//Sau khi NSD chọn file & nhập thông tin xong => Lưu file âm thanh vào thư mục App\AudioFiles và cập nhật thông tin file âm thanh vào DB
            {//B3: NẠP FILE ÂM THANH VÀO APP = GỒM 2 BƯỚC CƠ BẢN = COPY FILE ÂM THANH VÀO THƯ MỤC CỦA APP(AudioFiles) +Update THÔNG TIN FILE ÂM THANH VÀO DB
                if (ch == DialogResult.OK)//NSD đã đồng ý nạp file âm thanh đã chọn từ OpenFileDialog
                {
                    string tenfile = System.IO.Path.GetFileName(openFileDialog1.FileName);
                    //tên file âm thanh mà NSD đã chọn
                    //[1] COPY FILE ÂM THANH ĐÃ CHỌN VÀO THƯ MỤC ~\\FileAmThanh
                    try
                    {
                        File.Copy(openFileDialog1.FileName, audiopath + tenfile, true);// tự xử lý thêm 1 số lỗi như: nếu file đã tồn tại trong thư mục đích thì có chồng lên hay không, nếu file nguồn không tồn tại, nếu đường dẫn sai...v.v
                        //[1 TRONG 2 CÂU LỆNH QUANG TRỌNG] //openFileDialog1.FileName = Full path của file nguồn || System.IO.Path.GetFileName(...) lấy tên của path || true = chồng lên nêu trong thư mục đã có sẵn file
                    }
                    catch (System.Exception ex) { MessageBox.Show("Có lỗi copy file âm thanh:" + ex.Message); }

                    //[2] NẠP THÔNG TIN CỦA FILE ÂM THANH ĐÃ CHỌN VÀO DATABASE SQL
                    if (txtMaSo.Text != "" && txtMaSo.Text != "Quý vị phải nhập mã số file vào đây")
                    //NSD bắt buộc nhập mã số file âm thanh thì mới lưu được.
                    {
                        try
                        {
                            aUDIOFILESTableAdapter.Insert(txtMaSo.Text.Trim(), tenfile, audiopath + tenfile, 0, "", 0, txtDesc.Text);
                            //NẠP THÔNG TIN FILE ÂM THANH VÀO DB [1 TRONG 2 CÂU LỆNH QUANG TRỌNG]
                            //INSERT INTO AUDIOFILES
                                                //           (ms, filename, filepath, size, ext, length, description)
                            //VALUES (@ms,@filename,@filepath,@size,@ext,@length,@description)

                        }
                        catch (System.Exception ex)
                        { MessageBox.Show("Có lỗi khi nạp thông tin file âm thanh vào DB: " + ex.Message); }
                    }
                    else MessageBox.Show("Không được để trống mã file");

                    //B4: Tải file mới vừa nạp vào ListBox và nghe thử / axWMP = COPY xuống TỪ trên FrWMPManagement_Load(..)
                    try
                    {
                        // TODO: This line of code loads data into the 'A07PAL_SOSDataSet1.AUDIOFILES' table. You can move, or remove it, as needed.
                        this.aUDIOFILESTableAdapter.Fill(this.a07PALSOSDataSet.AUDIOFILES);
                    }
                    catch (Exception ex) { MessageBox.Show("Có lỗi tải các files âm thanh lên danh sách! " + ex.Message); }

                    BtnLoad.Text = "Nạp file mới";
                    //Trả lại nhãn ban đầu ["Nạp thêm files" copy từ Design sang, KHÔNG tự  nhập]
                }//NSD OK              
            }//Lưu file
        }// new = load

        /// <summary>
        /// THAY ĐỔI THÔNG TIN FILE ÂM THANH: //SỬA THÔNG TIN FILE ÂM THANH ĐÃ CÓ TRONG APP 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnModify_Click(object sender, EventArgs e)
        {
            //B1:Cho || cấm các nút lệnh các khác và textbox mô tả tin file âm thanh (không sửa được các thông khác)
            txtDesc.Enabled = !txtDesc.Enabled;
            BtnLoad.Enabled = !BtnLoad.Enabled;
            BtnRecord.Enabled = !BtnRecord.Enabled;
            BtnDelete.Enabled = !BtnDelete.Enabled;
            btnPlay.Enabled = !btnPlay.Enabled;
            BtnStop.Enabled = !BtnStop.Enabled;
            btnPause.Enabled = !btnPause.Enabled;
            BtnFast.Enabled = !BtnFast.Enabled;
            BtnSlow.Enabled = !BtnSlow.Enabled;
            BtnFirst.Enabled = !BtnFirst.Enabled;
            BtnLast.Enabled = !BtnLast.Enabled;
            BtnNext.Enabled = !BtnNext.Enabled;
            BtnPrev.Enabled = !BtnPrev.Enabled;
            //B2: ĐỔI NHÃN (.TEXT) CỦA NÚT LỆNH : "Sửa..." <-> "Lưu..."
            if (BtnModify.Text == "Sửa thông tin file")    //bắt đầu Sửa thông tin file âm thanh trong các TextBox ["Sửa thông tin files" copy từ Design sang, KHÔNG tự  nhập]
            {//Thông báo nhắc NSD cách sủa thông tin
                MessageBox.Show("Quý vị sửa mô tả file trong TextBox Mô tả phía trên, Không sửa được các thông thin khác."); //thông báo hướng dẫn NSD cách sửa thông tin file            
                BtnModify.Text = "Lưu sau sửa"; //Đổi nhãn (.Text) thành2 "Lưu...": tự nhập
            }
            else//Sau khi NSD sửa thông tin xong =>Lưu thông tin file âm thanh sau sửa vào DB
            {//B3: SỬA THÔNG TIN FILE ÂM THANH  + Update THÔNG TIN SỬA VÀO DB
                try
                {
                    aUDIOFILESTableAdapter.Update(txtDesc.Text, txtMaSo.Text.Trim());
                    //Lưu THÔNG TIN FILE ÂM THANH sau Sửa VÀO DB [CÂU LỆNH QUANG TRỌNG]
                }
                catch (System.Exception ex)
                { MessageBox.Show("Có lỗi khi SỬA thông tin file âm thanh: " + ex.Message); }

                //B4: Tải file mới vừa nạp vào ListBox và nghe thử / axWMP = COPY xuống TỪ trên FrWMPManagement_Load(..)
                try
                {
                    this.aUDIOFILESTableAdapter.Fill(this.a07PALSOSDataSet.AUDIOFILES);
                    //nạp DB files âm thanh
                }
                catch (System.Exception ex)
                { MessageBox.Show("Có lỗi tải các files âm thanh lên danh sách! " + ex.Message); }
                //B5: Đổi nhãn thành ban đầu
                BtnModify.Text = "Sửa thông tin file";
                //Trả lại nhãn ban đầu ["Sửa thông tin files" copy từ Design sang, KHÔNG tự  nhập]                
            }//else Lưu thông tin file vào DB

        } // Button quản lý modify

        // Xóa File Âm Thanh = Xóa file âm thanh đã có trong thư mục FileAmThanh + Xóa thông tin file âm thanh đó trong DB
        /// <summary>
        /// XÓA ÂM THANH ĐÃ CÓ TRONG APP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            //B1: HỎI XÁC NHẬN
            DialogResult ch = MessageBox.Show("Thiệt xóa file âm thanh: " + txtMaSo.Text.Trim() + " _ " + txtFileName.Text.Trim() + " không(Y/N)?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //B2: XÓA Khi NSD Y
            if (ch == DialogResult.Yes)//NSD đồng ý Xóa
            {
                try
                {
                    aUDIOFILESTableAdapter.Delete(txtMaSo.Text.Trim());//XÓA FILE ÂM THANH [CÂU LỆNH QUANG TRỌNG]
                }
                catch (System.Exception ex)
                { MessageBox.Show("Có lỗi khi XÓA file âm thanh: " + ex.Message); }
                //B3: Tải các file sau xóa lên ListBox = COPY xuống TỪ trên FrWMPManagement_Load(..)
                try
                {
                    this.aUDIOFILESTableAdapter.Fill(this.a07PALSOSDataSet.AUDIOFILES);
                    //nạp DB files âm thanh
                }
                catch (System.Exception ex)
                { MessageBox.Show("Có lỗi tải các files âm thanh lên danh sách! " + ex.Message); }
            }//If NSD Y

        }//Delete
    }//class
}// đóng namespace
