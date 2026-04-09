using System;
using System.Windows.Forms;

namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetupAccessibility();
            RegisterEvents(); // 이벤트 연결 메서드 호출
        }

        private void SetupAccessibility()
        {
            this.AcceptButton = btnOrder;

            // 모든 라디오 버튼에 Tab 포커스 허용
            rdoHamBurger.TabStop = true;
            rdoBulgogiBurger.TabStop = true;
            rdoChickenBurger.TabStop = true;

            // Tab 순서
            rdoHamBurger.TabIndex = 0;
            rdoBulgogiBurger.TabIndex = 1;
            rdoChickenBurger.TabIndex = 2;
            chkPotato.TabIndex = 3;
            chkCola.TabIndex = 4;
            chkCheese.TabIndex = 5;
            chkSauce.TabIndex = 6;
            btnOrder.TabIndex = 7;
            btnReset.TabIndex = 8;

            this.Load += (s, e) => rdoHamBurger.Focus();
        }

        // 모든 라디오 버튼과 체크박스의 상태가 바뀔 때 실행될 이벤트 연결
        private void RegisterEvents()
        {
            // 라디오 버튼 이벤트 연결
            rdoHamBurger.CheckedChanged += UpdateOrder;
            rdoBulgogiBurger.CheckedChanged += UpdateOrder;
            rdoChickenBurger.CheckedChanged += UpdateOrder;

            // 체크박스 이벤트 연결
            chkPotato.CheckedChanged += UpdateOrder;
            chkCola.CheckedChanged += UpdateOrder;
            chkCheese.CheckedChanged += UpdateOrder;
            chkSauce.CheckedChanged += UpdateOrder;
        }

        // 실시간으로 리스트박스와 금액을 업데이트하는 핵심 메서드
        private void UpdateOrder(object sender, EventArgs e)
        {
            // 이벤트가 발생할 때마다 리스트와 금액 초기화 후 재계산
            lstOrder.Items.Clear();
            int totalCost = 0;

            // 메인 메뉴 확인
            if (rdoHamBurger.Checked) { totalCost += 5000; lstOrder.Items.Add("햄버거 5,000원"); }
            else if (rdoBulgogiBurger.Checked) { totalCost += 4000; lstOrder.Items.Add("불고기버거 4,000원"); }
            else if (rdoChickenBurger.Checked) { totalCost += 3000; lstOrder.Items.Add("치킨버거 3,000원"); }

            // 옵션 메뉴 확인
            if (chkPotato.Checked) { totalCost += 3500; lstOrder.Items.Add("감자튀김 3,500원"); }
            if (chkCola.Checked) { totalCost += 2500; lstOrder.Items.Add("콜라 2,500원"); }
            if (chkCheese.Checked) { totalCost += 1500; lstOrder.Items.Add("치즈 추가 1,500원"); }
            if (chkSauce.Checked) { totalCost += 500; lstOrder.Items.Add("소스 추가 500원"); }

            lblTotalCost.Text = "총 금액: " + totalCost.ToString("N0") + "원";

            // 메뉴가 하나라도 선택되면 에러 메시지 숨김
            if (totalCost > 0) lblErrorMsg.Visible = false;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (lstOrder.Items.Count == 0)
            {
                lblErrorMsg.Visible = true;
                lblErrorMsg.Text = "메뉴를 먼저 선택해주세요.";
                return;
            }

            MessageBox.Show(lblTotalCost.Text + " 주문이 완료되었습니다!", "주문 완료");
            btnReset_Click(null, null); // 주문 후 초기화
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // 모든 체크 해제 (이때 연결된 UpdateOrder가 자동으로 실행됨)
            rdoHamBurger.Checked = false;
            rdoBulgogiBurger.Checked = false;
            rdoChickenBurger.Checked = false;
            chkPotato.Checked = false;
            chkCola.Checked = false;
            chkCheese.Checked = false;
            chkSauce.Checked = false;

            // 리셋 후 다시 Tab 포커스가 가도록 설정
            rdoHamBurger.TabStop = true;
            rdoBulgogiBurger.TabStop = true;
            rdoChickenBurger.TabStop = true;

            lblErrorMsg.Visible = false;
            rdoHamBurger.Focus();
        }
    }
}