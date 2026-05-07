#五張撲克牌遊戲（Poker）

##專案簡介
本專案使用 C# Windows Forms 開發，模擬五張撲克牌遊戲。  
玩家可以進行發牌、選擇要更換的牌、下注以及判斷牌型，並依照牌型賠率計算中獎金額。
本系統整合隨機抽牌、牌型判斷、下注機制與圖形介面操作，提升使用者互動體驗。


##功能說明

###發牌
隨機產生五張撲克牌並顯示於畫面。

###換牌
- 點擊牌可選擇要更換的牌（背景變黃色）
- 點擊「換牌」後只會更換選取的牌
- 
###下注功能
- 可輸入下注金額
- 判斷牌型後依賠率計算中獎金額
- 更新總資金

###判斷牌型
支援以下牌型與賠率：

| 牌型 | 賠率 |
| 皇家同花順 | 250 |
| 同花順 | 50 |
| 四條 | 25 |
| 葫蘆 | 9 |
| 同花 | 6 |
| 順子 | 4 |
| 三條 | 3 |
| 兩對 | 2 |
| 一對 | 1 |


##執行說明

###開發環境
- Visual Studio 2022
- .NET Framework（Windows Forms）

###執行步驟
1. 開啟專案（.sln 檔）
2. 點擊「開始（Start）」執行程式
3. 操作流程：
   - 點擊【發牌】
   - 點選要更換的牌（會變黃色）
   - 點擊【換牌】
   - 輸入下注金額並按【押注】
   - 點擊【判斷牌型】查看結果


##執行畫面（截圖）
<img width="2860" height="1650" alt="image" src="https://github.com/user-attachments/assets/2099d077-5cb8-474c-9a8d-024a801b47a1" />

###發牌畫面
<img width="1081" height="903" alt="image" src="https://github.com/user-attachments/assets/6ac8920e-3517-44d4-88d3-22aa07a54c6b" />

###換牌畫面
<img width="1069" height="911" alt="image" src="https://github.com/user-attachments/assets/471ae12a-c0a7-49d1-bafd-58364d24108e" />
<img width="1080" height="866" alt="image" src="https://github.com/user-attachments/assets/4d3bf766-d4c6-48c1-9914-799b11e8e4f0" />
<img width="1073" height="882" alt="image" src="https://github.com/user-attachments/assets/0e210dca-63bb-4eb5-bcfa-3c0aacc944f6" />

###判斷牌型
<img width="1087" height="917" alt="image" src="https://github.com/user-attachments/assets/f064f849-ac87-4647-bbb9-f6282a211e2e" />

###押注結果
<img width="1085" height="916" alt="image" src="https://github.com/user-attachments/assets/144b6896-4bfa-4a01-ab4e-2ebe2e4f9027" />



##使用技術
- C#
- Windows Forms
- Random 隨機數
- 資源管理（Resources）
- 事件驅動（Click Event）

##Commit History（開發紀錄）
本專案透過 GitHub 進行版本控制，  
並使用具語意的 Commit 紀錄開發流程，內容包含：
- 建立 Windows Forms 撲克牌介面
- 加入撲克牌圖片與 Resources 管理
- 完成隨機發牌功能
- 新增換牌功能與牌面選取效果
- 完成牌型判斷邏輯
- 加入下注與賠率計算功能
- 修正換牌與圖片顯示問題
- 美化使用者介面
- 新增 README 與執行截圖

##備註
- 圖片已使用 Resources 管理，不需額外資料夾
- 已依作業要求實作下注與賠率計算
- 繳交前已移除 bin / obj / .vs 資料夾


##心得
透過本專案學習到：
- Windows Forms UI 設計
- 事件處理機制
- 撲克牌牌型判斷邏輯
- 程式與使用者互動設計

提升了程式邏輯與實作能力。
