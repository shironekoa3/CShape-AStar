using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetShortest
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        public static int panelWidthNum = 30;
        public static int panelHeightNum = 18;
        public static int picWidth = 25;
        public static int picHeight = 25;

        public static int SET_VALUE = 0;

        //保存 起点 障碍物点 终点
        public static Point PointStart = new Point();
        public static List<Point> PointObs = new List<Point>();
        public static Point PointEnd = new Point();

        private void FrmMain_Load(object sender, EventArgs e)
        {
            InitPanel();
        }
        private void btnInitPanel_Click(object sender, EventArgs e)
        {
            this.btnInitPanel.Enabled = false;
            InitPanel();
            this.btnInitPanel.Enabled = true;
        }
        private void btnSetStart_Click(object sender, EventArgs e)
        {
            SET_VALUE = 1;
        }
        private void btnSetObs_Click(object sender, EventArgs e)
        {
            SET_VALUE = 2;
        }
        private void btnSetEnd_Click(object sender, EventArgs e)
        {
            SET_VALUE = 3;
        }
        private void btnClearTip_Click(object sender, EventArgs e)
        {
            txtTip.Text = "";
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            CalcWays();
        }

        public void InitPanel()
        {
            this.plMain.Controls.Clear();
            PointStart = new Point();
            PointObs = new List<Point>();
            PointEnd = new Point();
            for (int i = 0; i < panelHeightNum; i++)
            {
                for (int j = 0; j < panelWidthNum; j++)
                {
                    PictureBox pbx = new PictureBox();
                    pbx.Location = new Point(j * picWidth, i * picHeight);
                    pbx.Size = new Size(picWidth, picHeight);
                    pbx.Margin = new Padding(0, 0, 0, 0);
                    pbx.BorderStyle = BorderStyle.FixedSingle;
                    pbx.BackColor = Color.Gray;
                    pbx.Name = (i * panelWidthNum + j + 1).ToString();
                    pbx.MouseDown += new MouseEventHandler(picMouseDown);
                    this.plMain.Controls.Add(pbx);
                    this.Update();
                }
            }
        }
        public void picMouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pbx = (PictureBox)sender;
            if (e.Button == MouseButtons.Left)
            {
                SetPoint(pbx);
            }
            else if (e.Button == MouseButtons.Right)
            {
                CancelPoint(Convert.ToInt32(pbx.Name));
            }
        }
        public void SetPoint(PictureBox pbx)
        {
            switch (SET_VALUE)
            {
                case 1:
                    if (PointStart.X != 0 || PointStart.Y != 0)
                        CancelPoint((PointStart.Y - 1) * panelWidthNum + PointStart.X);
                    PointStart = GetPoint(Convert.ToInt32(pbx.Name));
                    pbx.BackColor = Color.Lime;
                    SetTip("设置起点坐标(" + PointStart.X + "," + PointStart.Y + ").");
                    break;
                case 2:
                    if (pbx.BackColor == Color.Black) break;
                    Point tempPoint = GetPoint(Convert.ToInt32(pbx.Name));
                    PointObs.Add(tempPoint);
                    pbx.BackColor = Color.Black;
                    SetTip("设置障碍物坐标(" + tempPoint.X + "," + tempPoint.Y + ").");
                    break;
                case 3:
                    if (PointEnd.X != 0 || PointEnd.Y != 0)
                        CancelPoint((PointEnd.Y - 1) * panelWidthNum + PointEnd.X);
                    PointEnd = GetPoint(Convert.ToInt32(pbx.Name));
                    pbx.BackColor = Color.Red;
                    SetTip("设置终点坐标(" + PointEnd.X + "," + PointEnd.Y + ").");
                    break;
                default:
                    break;
            }
        }
        public void CancelPoint(int index)
        {
            PictureBox tempPic = new PictureBox();
            foreach (Control item in this.plMain.Controls)
            {
                if (item is PictureBox)
                {
                    tempPic = (PictureBox)item;
                    if (tempPic.Name == index.ToString())
                    {
                        if (tempPic.BackColor == Color.Lime)
                        {
                            PointStart = new Point();
                        }
                        else if (tempPic.BackColor == Color.Red)
                        {
                            PointEnd = new Point();
                        }
                        else if (tempPic.BackColor == Color.Black)
                        {
                            PointObs.Remove(GetPoint(index));
                            SetTip("剩余障碍物数量:" + PointObs.Count.ToString());
                        }
                        tempPic.BackColor = Color.Gray;
                    }
                }
            }
        }
        public Point GetPoint(int index)
        {
            Point result = new Point();
            result.X = index % panelWidthNum == 0 ? panelWidthNum : index % panelWidthNum;
            result.Y = index % panelWidthNum == 0 ? index / panelWidthNum : index / panelWidthNum + 1;
            return result;
        }
        public void SetTip(string str)
        {
            this.txtTip.Text += str + "\r\n";
            this.txtTip.Select(this.txtTip.TextLength, 0);
            this.txtTip.ScrollToCaret();
        }

        //=======================================================================

        List<APoint> OpenList = new List<APoint>();
        List<APoint> CloseList = new List<APoint>();
        List<int> ChangeNums = new List<int>();
        List<APoint> ApResult = new List<APoint>();//保存结果
        
        public APoint GetApStart(Point tempStart,Point tempEnd)
        {
            APoint apStart = new APoint();
            apStart.xPos = tempStart.X;
            apStart.yPos = tempStart.Y;
            apStart.gCost = 0;
            apStart.hCost = Math.Abs(tempEnd.X - tempStart.X) + Math.Abs(tempEnd.Y - tempStart.Y);
            return apStart;
        }
        public APoint GetApEnd(Point tempStart, Point tempEnd)
        {
            APoint apEnd = new APoint();
            apEnd.xPos = tempEnd.X;
            apEnd.yPos = tempEnd.Y;
            apEnd.gCost = Math.Abs(tempEnd.X - tempStart.X) + Math.Abs(tempEnd.Y - tempStart.Y);
            apEnd.hCost = 0;
            return apEnd;
        }

        //从OpenList中取估价最低的点
        public APoint GetMinFFromOpenList()
        {
            APoint apFMin = OpenList[0];
            foreach (APoint item in OpenList)
            {
                if(item.fCost < apFMin.fCost)
                {
                    apFMin = item;
                }
            }
            return apFMin;
        }
        
        //判断方块的有效性
        public bool IsGood(APoint apTemp)
        {
            bool flag = true;
            //判断边界
            if (apTemp.xPos < 1 || apTemp.yPos < 1|| apTemp.xPos> panelWidthNum || apTemp.yPos > panelHeightNum)
            {
                flag = false;
            }

            //判断是否在CloseList
            foreach(APoint item in CloseList)
            {
                if(item.xPos == apTemp.xPos && item.yPos == apTemp.yPos)
                {
                    flag = false;
                }
            }
            return flag;
        }

        //修改方块颜色(如果方块没有颜色则修改并记录)
        public void SetColor(APoint apTemp,int v = 0)
        {
            int num = (apTemp.yPos - 1) * panelWidthNum + apTemp.xPos;
            foreach (Control item in this.plMain.Controls)
            {
                if (item.Name == num.ToString())
                {
                    if (item.BackColor == Color.Lime || item.BackColor == Color.Red) break;
                    if (v == 0)
                    {
                        item.BackColor = Color.Turquoise;
                        ChangeNums.Add(num);
                    }
                    else if (v == 1)
                    {
                        item.BackColor = Color.Teal;
                        ChangeNums.Add(num);
                    }
                    else if(v == 2)
                    {
                        item.BackColor = Color.Aqua;
                    }
                    else if (v == -1)
                    {
                        item.BackColor = Color.Gray;
                    }
                    break;
                }
            }
            
        }
        
        //计算
        public void CalcWays()
        {
            OpenList.Clear();
            CloseList.Clear();
            ChangeNums.Clear();

            //将障碍物点添加至CloseList
            foreach (Point item in PointObs)
            {
                APoint temp = new APoint(item.X, item.Y, null, null, null);
                CloseList.Add(temp);
            }
            
            //清除原路线颜色
            bool tempFlag = false;
            for (int i = ApResult.Count - 2; i >= 1; i--)
            {
                foreach (APoint item in CloseList)
                {
                    if (item.xPos == ApResult[i].xPos && item.yPos == ApResult[i].yPos)
                    {
                        tempFlag = true;
                    }
                }
                if(!tempFlag)
                {
                    SetColor(ApResult[i], -1);
                    Thread.Sleep(20);
                    this.Update();
                }
                tempFlag = false;
            }
            ApResult.Clear();
            

            APoint apStart = GetApStart(PointStart, PointEnd);
            APoint apEnd = GetApEnd(PointStart, PointEnd);
            
            OpenList.Add(apStart);
            //开始循环判断
            APoint apFMin = null;
            while (OpenList.Count > 0)
            {
                //获取OpenList中最小的估值的方块
                apFMin = GetMinFFromOpenList();
                if (apFMin.xPos == apEnd.xPos && apFMin.yPos == apEnd.yPos) break;
                SetColor(apFMin, 1);

                //将当前节点周围的点放入OpenList中
                #region 将当前节点周围的四个点放入OpenList中，并修改为淡蓝色
                APoint apTempLeft = new APoint(apFMin.xPos - 1, apFMin.yPos, apStart, apEnd, apFMin);
                if (IsGood(apTempLeft))
                {
                    OpenList.Add(apTempLeft);
                    SetColor(apTempLeft);
                }
                APoint apTempUp = new APoint(apFMin.xPos, apFMin.yPos - 1, apStart, apEnd, apFMin);
                if (IsGood(apTempUp))
                {
                    OpenList.Add(apTempUp);
                    SetColor(apTempUp);
                }
                APoint apTempRight = new APoint(apFMin.xPos + 1, apFMin.yPos, apStart, apEnd, apFMin);
                if (IsGood(apTempRight))
                {
                    OpenList.Add(apTempRight);
                    SetColor(apTempRight);
                }
                APoint apTempDown = new APoint(apFMin.xPos, apFMin.yPos + 1, apStart, apEnd, apFMin);
                if (IsGood(apTempDown))
                {
                    OpenList.Add(apTempDown);
                    SetColor(apTempDown);
                }
                #endregion
                
                //将当前节点放入CloseList中
                OpenList.Remove(apFMin);
                CloseList.Add(apFMin);
                //Thread.Sleep(1);
                this.Update();
            }

            //清除方块颜色的修改
            foreach(int item in ChangeNums)
            {
                int x = item % panelWidthNum == 0 ? panelWidthNum : item % panelWidthNum;
                int y = item % panelWidthNum == 0 ? item / panelWidthNum : item / panelWidthNum + 1;
                APoint temp = new APoint(x, y, null, null, null);
                SetColor(temp, -1);
                this.Update();
            }

            //连线
            ApResult.Add(apFMin);
            while (apFMin.parent != null)
            {
                ApResult.Add(apFMin.parent);
                apFMin = apFMin.parent;
            }
            for (int i = ApResult.Count - 1; i >= 0; i--)
            {
                SetColor(ApResult[i], 2);
                Thread.Sleep(20);
                this.Update();
            }

            SetTip("一共需要移动 " + (ApResult.Count - 1).ToString() + " 格.");

        }
    }

    public class APoint
    {
        public int xPos;
        public int yPos;
        public int gCost;
        public int hCost;
        public int fCost
        {
            get { return gCost * 8 / 10 + hCost * 8 / 5; }
        }

        public APoint parent;

        public APoint() { }
        public APoint(int x, int y, APoint apStart, APoint apEnd, APoint tparent)
        {
            this.xPos = x;
            this.yPos = y;
            
            //赋值parent并计算G值
            if (tparent != null)
            {
                this.parent = tparent;
                this.gCost = 1;
                APoint apTemp = tparent;
                while (apTemp.parent != null)
                {
                    this.gCost++;
                    apTemp = apTemp.parent;
                }
            }

            //计算H值
            if (apEnd == null) this.hCost = 0;
            else this.hCost = Math.Abs(apEnd.xPos - x) + Math.Abs(apEnd.yPos - y);

        }
    }

}
