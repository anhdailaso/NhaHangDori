using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cas.Areas.Vietcon.Helpers
{
    public enum StatusCategory
    {
        dyeing_request,
        dyeing_order,
        dyeing_processing,
        order_delivery,
        online_approval,
        mail_box,
        dyeing_category,
        dyeing_method,
        store_statuses,
        color_status,
        dyeing_unit,
        color_category,
        yarn_type,
        order_step,
        order_item_status,
        yarn_type_statuses,
        YCTM,
        DDH,
        tong_mau,
        currency,
        order_group,
        noi_nhuom,
        QTN,
        PGH,
        HTV,
        HTV_SOLUTION,
        dvt_color_formula,
        approval_level_category,
        anh_den_xem_mau,
		color_code_string,
		color_code_number
    }

    public enum GroupLog
    {
        vietcon = 1,
        customer = 2
    }

    public enum ColorCategory
    {
        vietcon = 1,
        customer = 2
    }

    public enum VcStatus
    {
        //dyeing_request_deny_test_result = 5,
        dyeing_order_complete = 6,
        dyeing_order_send_to_approve = 1,
        deleted = -2,
        drying = 8,
        mail_sent = -1,
        mail_not_read = 0,
        mail_read = 1,
        order_item_dyeing = 1,
        order_item_done = 2,
        order_approved = 3,
        order_dyeing = 5,
        order_item_step_done = 1,
    }

    public enum DR_FB_Status
    {
        dr_fb_send_request = 2,
        dr_fb_send_color = 3,
        dr_fb_agree = 4,
        dr_fb_deny = 22,
        dr_fb_completed = 6,
        dr_fb_canceled = -1
    }

    public enum RequestStatus
    {
        dyeing_request_new = 0,
        dyeing_request_send_request = 1,
        dyeing_request_check_color = 2,
        dyeing_request_send_color = 3,
        dyeing_request_agree = 4,
        dyeing_request_deny = 5,
        dyeing_request_completed = 6,
        dyeing_request_canceled = -1,
    }

    public enum DyeingOrderStatus
    {
        dyeing_order_new = 0, //moi
        dyeing_order_pending = 1, //cho duyet
        dyeing_order_approving = 2, //dang duyet
        dyeing_order_approved = 3, //da duyet
        dyeing_order_rejected = 4, //da tu choi
        dyeing_order_dyeing = 5, //dang nhuom
        dyeing_order_completed = 6, //hoan thanh
        //dyeing_order_dyeing_completed = 8, //nhuom xong
        dyeing_order_cancel = -1, //huy bo
        dyeing_order_dyeing_splitted = 7 //da chia lan nhuom
    }

    // 
    // 0	   -   Mới
    // 1	   -   Yêu cầu xuất kho
    // 2	   -   Từ chối xuất kho
    // 3	   -   Đã xuất kho
    // 4	   -   Đã ra cổng
    // 5	   -   Từ chối ra cổng
    // 6	   -   Đã nhập lại kho
    // 7	   -   Đã giao hàng
    // 8	   -   Hoàn tất
    // 100	   -   Chờ Duyệt
    // 101	   -   Đang Duyệt
    // 102	   -   Đã duyệt
    // 103	   -   Đã từ chối duyệt
    public enum VcDeliveryStatus
    {
        delivery_new = 0,
        delivery_request = 1,
        delivery_refusing = 2,
        delivery_already_warehousing = 3,
        delivery_gate = 4,
        delivery_refusing_gate = 5,
        delivery_enter_warehousing = 6,
        delivery_ship = 7,
        delivery_completed = 8,
        delivery_wait_approve = 100,
        delivery_wait_approving = 101,
        delivery_approve = 102,
        delivery_refuse_approve = 103,
    }

    public enum PGHStatus
    {
        Moi = 0,
        YeuCauXuatKho = 1,
        TuChoiXuatKho = 2,
        DaXuatKho = 3,
        DaRaCong = 4,
        TuChoiRaCong = 5,
        DaNhapLaiKho = 6,
        DaGiaoHang = 7,
        HoaTat = 8,
        HuyBo = -1,
        DaDuyet = 9,
        DaTuChoiDuyet = 10,
        ChoDuyet = 11
    }

    public enum ApprovalStatus
    {
        NEW = 0,
        APPROVING = 1,
        APPROVED = 2,
        DENIED = -1
    }

    public enum RequestType
    {
        ORDER = 2,
        DELIVERY = 1
    }

    public enum VcDyeingOrderSetItemStatus
    {
        NEW = 0, //mới
        PROCESS = 1, //đang nhuộm
        DONE = 2, //đã hoàn thành
        SENT_PATTERN = 3, //đã gởi mẫu
    }

    public enum YCTMStatus
    {
        Moi = 0,
        HoaNghiemDangTest = 1,
        HoaNghiemTestXong = 2,
        DaGoiKH = 3,
        KHDongY = 4,
        KHTuChoi = -1,
        HuyBo = -2,
        DaTaoDDH = 5,
        HoanTat = 6
    }

    public enum YCTMButton
    {
        TaoMoi = 100,
        GoiHoaNghiem = 101,
        HoaNghiemTestXong = 102,
        GoiKhachHang = 103,
        DongY = 104,
        TuChoi = 105,
        HoaNghiemTestLai = 106,
        HuyBo = 107,
        TaoMoiDDH = 108,
        HoanTat = 109
    }

    public enum MessageType
    {
        success = 1,
        inform = 2,
        error = 3
    }

    public enum QTNStatus
    {
        Incompleted = 0,
        Completed = 1,
        SentPattern = 2
    }

    public enum HTVStatus
    {
        New = 0,
        Inprogress = 1,
        Completed = 2,
        Deleted = -2
    }

    public enum HTVSolutionStatus
    {
        LuuTru = 1,
        NhuomLai = 2
    }

    public enum DyeingStep
    {
        XuatKhoChaySoiTho = 1,
        ChaySoiTho = 2,
        CanSoi = 3,
        HoaNghiem = 4,
        QuanLySanXuat = 5,
        NhuomSoi = 6,
        VatNuocSayKho = 7,
        KiemPham = 8,
        CuonThanhPham = 9,
        DongGoi = 10,
        NhapKhoThanhPham = 11
    }
}