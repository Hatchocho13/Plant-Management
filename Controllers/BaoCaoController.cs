using System;
using System.Collections.Generic;
using System.Data;
using PlantManagement.Helpers;
using PlantManagement.Models;

namespace PlantManagement.Controllers
{
    public class BaoCaoController
    {
        private readonly DatabaseHelper _dbHelper;

        public BaoCaoController()
        {
            _dbHelper = new DatabaseHelper();
        }

        public List<User> GetUserList()
        {
            var userList = new List<User>();

            try
            {
                string query = @"
            SELECT 
                u.ID, u.UserName, u.FullName, u.Email, u.IsActive, u.CreatedAt, u.ID_Group, ug.GroupName
            FROM [User] u
            LEFT JOIN UserGroup ug ON u.ID_Group = ug.ID
            ORDER BY u.UserName";

                using (var dataTable = _dbHelper.ExecuteQuery(query))
                {
                    if (dataTable != null && dataTable.Rows.Count > 0)
                    {
                        foreach (DataRow row in dataTable.Rows)
                        {
                            var user = new User
                            {
                                ID = Convert.ToInt32(row["ID"]),
                                UserName = row["UserName"].ToString(),
                                FullName = row["FullName"].ToString(),
                                Email = row["Email"].ToString(),
                                IsActive = Convert.ToBoolean(row["IsActive"]),
                                CreatedAt = Convert.ToDateTime(row["CreatedAt"]),
                                ID_Group = Convert.ToInt32(row["ID_Group"]) // Giữ nguyên ID_Group
                            };

                            // Thêm GroupName từ bảng UserGroup
                            user.GroupName = row["GroupName"].ToString();

                            userList.Add(user);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching user list: {ex.Message}");
            }

            return userList;
        }


        public List<LoginHistory> GetLoginHistoryWithFullName()
{
    var loginHistoryList = new List<LoginHistory>();

    try
    {
        string query = @"
            SELECT 
                lh.ID, 
                lh.UserID, 
                u.FullName, 
                lh.LoginTime, 
                lh.IPAddress
            FROM LoginHistory lh
            INNER JOIN [User] u ON lh.UserID = u.ID
            ORDER BY lh.LoginTime DESC";

        using (var dataTable = _dbHelper.ExecuteQuery(query))
        {
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    var loginHistory = new LoginHistory
                    {
                        ID = Convert.ToInt32(row["ID"]),
                        UserID = Convert.ToInt32(row["UserID"]),
                        FullName = row["FullName"].ToString(),  // Thêm FullName
                        LoginTime = Convert.ToDateTime(row["LoginTime"]),
                        IPAddress = row["IPAddress"].ToString()
                    };

                    loginHistoryList.Add(loginHistory);
                }
            }
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error fetching login history: {ex.Message}");
    }

    return loginHistoryList;
}

        public List<LoginHistoryCount> GetLoginHistoryCount()
        {
            var loginHistoryCountList = new List<LoginHistoryCount>();

            try
            {
                string query = @"
            SELECT 
                u.UserName AS 'Tên người dùng',
                COUNT(LH.ID) AS 'Số lần đăng nhập'
            FROM LoginHistory LH
            INNER JOIN [User] u ON LH.UserID = u.ID
            GROUP BY u.UserName
            ORDER BY COUNT(LH.ID) DESC;";

                using (var dataTable = _dbHelper.ExecuteQuery(query))
                {
                    if (dataTable != null && dataTable.Rows.Count > 0)
                    {
                        foreach (DataRow row in dataTable.Rows)
                        {
                            var loginHistoryCount = new LoginHistoryCount
                            {
                                UserName = row["Tên người dùng"].ToString(),
                                LoginCount = Convert.ToInt32(row["Số lần đăng nhập"])
                            };

                            loginHistoryCountList.Add(loginHistoryCount);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching login history count: {ex.Message}");
            }

            return loginHistoryCountList;
        }

        public List<TongHopData> GetTongHopData()
        {
            var tongHopList = new List<TongHopData>();

            try
            {
                string query = @"
        SELECT 
            gc.TenGiong AS [Giống cây trồng],
            dvhc.TenDVHC AS [Khu vực hành chính],
            vcd.TenVuonCay AS [Vườn cây đầu dòng],
            csx.TenCS AS [Cơ sở sản xuất],
            csbb.TenCS AS [Cơ sở buôn bán],
            tb.TenThuoc AS [Thuốc BVTV],
            pb.TenPhanBon AS [Phân bón],
            svgh.TenSVGH AS [Sinh vật gây hại],
            sx.CSAnToanVietGap AS [Sản xuất trồng trọt]
        FROM GiongCayTrong gc
        LEFT JOIN GiongCay_LuuHanh glh ON gc.ID = glh.ID_GiongCay
        LEFT JOIN DonViHanhChinh dvhc ON glh.ID_DVHC = dvhc.ID
        LEFT JOIN VuonCayDauDong vcd ON gc.ID = vcd.ID_GiongCayTrong
        LEFT JOIN CoSoSanXuat csx ON dvhc.ID = csx.ID_DVHC
        LEFT JOIN CoSoBuonBan csbb ON dvhc.ID = csbb.ID_DVHC
        LEFT JOIN ThuocBVTV tb ON csx.ID = tb.ID_CSSX OR csbb.ID = tb.ID_CSBB
        LEFT JOIN PhanBon pb ON csx.ID = pb.ID_CSSX OR csbb.ID = pb.ID_CSBB
        LEFT JOIN SXTT sx ON dvhc.ID = sx.ID_DVHC
        LEFT JOIN SinhVatGayHai svgh ON sx.ID_SVGH = svgh.ID";

                using (var dataTable = _dbHelper.ExecuteQuery(query))
                {
                    if (dataTable != null && dataTable.Rows.Count > 0)
                    {
                        foreach (DataRow row in dataTable.Rows)
                        {
                            var tongHop = new TongHopData
                            {
                                GiongCayTrong = row["Giống cây trồng"].ToString(),
                                KhuVucHanhChinh = row["Khu vực hành chính"].ToString(),
                                VuonCayDauDong = row["Vườn cây đầu dòng"].ToString(),
                                CoSoSanXuat = row["Cơ sở sản xuất"].ToString(),
                                CoSoBuanBan = row["Cơ sở buôn bán"].ToString(),
                                ThuocBVTV = row["Thuốc BVTV"].ToString(),
                                PhanBon = row["Phân bón"].ToString(),
                                SinhVatGayHai = row["Sinh vật gây hại"].ToString(),
                                SanXuatTrongTrot = row["Sản xuất trồng trọt"].ToString()
                            };

                            tongHopList.Add(tongHop);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching report data: {ex.Message}");
            }

            return tongHopList;
        }





    }
}
