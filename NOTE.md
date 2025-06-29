# Model建置方式：
1. Database First (DBFirst)
	先有資料庫，再依資料庫建立模型
2. Code First
	先寫模型類別，再依類別建立資料庫

* 資料塑模：
	1. 資料
		* UseCase

		ER圖->DB  
		Class圖->Class Code

	2. 流程（系統分析）
		* 流程圖

# 資料存取層 (Data Access Layer DAL)

# nvarchar vs. varchar
n : Unicode格式  
varchar 內中文字通常會佔 2 個位元組（byte）

# 必要的例外處理，需自行加入
1. 操作資料庫
2. 檔案處理

# ViewData生命週期
僅能跨一個Action(e.g.點下切換頁面按鈕後顯示的第一個頁面)

# 路由參數
asp-route-id：預設路由模板，使用該方法時網址會變成AAA/BBB\
asp-route-自訂參數名稱：未在路由中定義參數名稱，使用該方法時網址會變成AAA/?自訂參數名稱=參數值

# 新增資料庫登入使用者
1. 伺服器：安全性->登入->新增登入->選擇SQL Server驗證後輸入帳密、取消強制執行密碼原則
2. 伺服器：屬性->安全性->伺服器驗證：SQL Server及Windows驗證模式
3. 開啟SQL Server 2022 安全管理員：重啟MSSQLSERVER

# 自動建立模型 1.2.3
1. 使用套件管理器主控台(檢視 > 其他視窗 > 套件管理器主控台)
2. 輸入以下內容：Scaffold-DbContext "Data Source=伺服器位址;Database=資料庫名稱;TrustServerCertificate=True;User ID=帳號;Password=密碼" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -NoOnConfiguring -UseDatabaseNames -NoPluralize -

### 參數說明
TrustServerCertificate=True：信任伺服器憑證\
-NoOnConfiguring：不要在DBContext內生成OnConfiguring方法

# CRUD (增刪修查)
利用模型自動產生
1. 將Controller中建立_context的過程皆註解掉後，直接new新的dbStudentsContext()
2. 加入控制器->使用Entity Framework執行檢視的MVC控制器
3. 模型類別：tStudent
4. DbContext：dbStudentsContext
5. 在dbStudentsContext.cs終將預設的dbStudentsContext註解後直接創建一個空建構子(1.2.5)，再新增OnConfiguring方法(1.2.4)
6. 執行tStudents/Index.cshtml(使用瀏覽器檢視)