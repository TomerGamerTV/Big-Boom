using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreDevs_API;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        readonly ExploitAPI api = new ExploitAPI();

        public Form1()
        {
            InitializeComponent();
        }

        private void FlatButton2_Click(object sender, EventArgs e)
        {
            api.LaunchExploit();
        }

        private void InjectedChecker_Tick(object sender, EventArgs e)
        {
            CheckInjected();
        }

        private void CheckInjected()
        {
            if (api.isAPIAttached())
            {
                //The exploit is injected and now ready to execute scripts/commands
                txtIsInjected.Text = "Is Injected: true";
            }
            else
            {
                //The exploit is not injected... The client must inject
                txtIsInjected.Text = "Is Injected: false";
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CheckInjected();
        }

        private void FlatButton1_Click(object sender, EventArgs e)
        {
            string script = fastColoredTextBox1.Text;
            api.SendLimitedLuaScript(script);
        }

        private void FlatButton3_Click(object sender, EventArgs e)
        {
            string speed = textBox1.Text;
            api.SendLimitedLuaScript("game.Players.LocalPlayer.Character.Humanoid.WalkSpeed=" + speed);
        }

        private void FlatButton4_Click(object sender, EventArgs e)
        {
            api.SendCommand("btools me");
        }

        private void FlatButton5_Click(object sender, EventArgs e)
        {
            string username = inputTPTo.Text;
            api.SendCommand("teleport " + username);
        }

        private void FlatCheckBox1_CheckedChanged(object sender)
        {
            bool @checked = this.flatCheckBox1.Checked;
            if (@checked)
            {
                base.TopMost = true;
            }
            else
            {
                base.TopMost = false;
            }
        }

        private void FlatButton7_Click(object sender, EventArgs e)
        {
            this.api.CreateForceField("me");
        }

        private void FlatButton6_Click(object sender, EventArgs e)
        {
            this.api.SendLimitedLuaScript("_G.infinjump = not _G.infinjump\n\nlocal plr = game:GetService'Players'.LocalPlayer\nlocal m = plr:GetMouse()\nm.KeyDown:connect(function(k)\n\tif _G.infinjump then\n\t\tif k:byte() == 32 then\n\t\tplrh = game:GetService'Players'.LocalPlayer.Character:FindFirstChildOfClass'Humanoid'\n\t\tplrh:ChangeState('Jumping')\n\t\twait()\n\t\tplrh:ChangeState('Seated')\n\t\tend\n\tend\nend)");
        }

        private void FlatButton8_Click(object sender, EventArgs e)
        {
            this.api.SendScript("getglobal game\ngetfield -1 Players\ngetfield -1 LocalPlayer\ngetfield -1 Character\ngetfield -1 HumanoidRootPart\ngetglobal CFrame\ngetfield -1 new\npushnumber -60.7363625\npushnumber -361.700012\npushnumber 8765.66113\npcall 3 1 0\nsetfield -3 CFrame");
        }

        private void FlatButton9_Click(object sender, EventArgs e)
        {
            this.api.SendScript("getglobal game\ngetfield -1 Players\ngetfield -1 LocalPlayer\ngetfield -1 Data\ngetfield -1 TitaniumBlock\npushnumber 9000000\nsetfield -2 Value");
        }

        private void FlatButton10_Click(object sender, EventArgs e)
        {
            this.api.SendLimitedLuaScript("local ScreenGui = Instance.new('ScreenGui')\nlocal Holder = Instance.new('Frame')\nlocal Title = Instance.new('TextLabel')\nlocal TitleDrop = Instance.new('TextLabel')\nlocal ScrollingFrame = Instance.new('ScrollingFrame')\nlocal Title2 = Instance.new('TextLabel')\nlocal Title2Drop = Instance.new('TextLabel')\nScreenGui.Parent = game.Players.LocalPlayer.PlayerGui\nHolder.Name = 'Holder'\nHolder.Parent = ScreenGui\nHolder.Active = true\nHolder.AnchorPoint = Vector2.new(0, 0.5)\nHolder.BackgroundColor3 = Color3.new(0.298039, 0.298039, 0.298039)\nHolder.BorderSizePixel = 0\nHolder.Draggable = true\nHolder.Position = UDim2.new(0, 25, 0.5, 0)\nHolder.Size = UDim2.new(0, 150, 0, 290)\nTitle.Name = 'Title'\nTitle.Parent = Holder\nTitle.BackgroundColor3 = Color3.new(1, 1, 1)\nTitle.BackgroundTransparency = 1\nTitle.Size = UDim2.new(0, 150, 0, 10)\nTitle.ZIndex = 2\nTitle.Font = Enum.Font.SourceSansBold\nTitle.FontSize = Enum.FontSize.Size14\nTitle.Text = 'ROCITIZEN ITEM'\nTitle.TextColor3 = Color3.new(.1, 1, 1)\nTitle.TextSize = 14\nTitle.TextYAlignment = Enum.TextYAlignment.Top\nScrollingFrame.Parent = Holder\nScrollingFrame.AnchorPoint = Vector2.new(0.5, 0.5)\nScrollingFrame.BackgroundColor3 = Color3.new(0.196078, 0.196078, 0.196078)\nScrollingFrame.BorderSizePixel = 0\nScrollingFrame.Position = UDim2.new(0.5, 0, 0, 155)\nScrollingFrame.Size = UDim2.new(0, 140, 0, 250)\nScrollingFrame.BottomImage = 'rbxassetid://985424344'\nScrollingFrame.CanvasSize = UDim2.new(0, 0, 0, 0)\nScrollingFrame.MidImage = 'rbxassetid://985424344'\nScrollingFrame.ScrollBarThickness = 3\nScrollingFrame.TopImage = 'rbxassetid://985424344'\nTitle2.Name = 'Title2'\nTitle2.Parent = Holder\nTitle2.BackgroundColor3 = Color3.new(1, 1, 1)\nTitle2.BackgroundTransparency = 1\nTitle2.Position = UDim2.new(0, 0, 0, 10)\nTitle2.Size = UDim2.new(0, 150, 0, 10)\nTitle2.ZIndex = 2\nTitle2.Font = Enum.Font.SourceSansBold\nTitle2.FontSize = Enum.FontSize.Size14\nTitle2.Text = 'PLACE CHANGE GUI'\nTitle2.TextColor3 = Color3.new(.1, 1, 1)\nTitle2.TextSize = 14\nTitle2.TextYAlignment = Enum.TextYAlignment.Top\n \n--main script--\n \nlocal frameitems = {\n}\n \nlocal gg = game.ReplicatedStorage.Furniture:GetChildren()\nfor i = 1,#gg do\ntable.insert(frameitems,gg[i].Name)\n \nend\n \nlocal frame = ScrollingFrame\nfor i=1, #frameitems do\nlocal B = Instance.new('TextButton')\nlocal V = Instance.new('StringValue', B)\nV.Value = string.sub(frameitems[i], 7)\nB.Name = 'B'\nB.Parent = frame\nB.BackgroundColor3 = Color3.new(0.282353, 0.282353, 0.282353)\nB.BorderSizePixel = 0\nB.Position = UDim2.new(0, 3, 0, (((i-1)*22)+(3*i)))\nB.Size = UDim2.new(0, 134, 0, 22)\nB.Font = Enum.Font.SourceSansBold\nB.FontSize = Enum.FontSize.Size14\nB.Text = frameitems[i]\nB.TextColor3 = Color3.new(.1, .5, .5)\nB.TextScaled = true\nB.TextSize = 20\nframe.CanvasSize = UDim2.new(0,0,0,(#frameitems*22+(i*3)+3))\nB.MouseButton1Down:connect(function()\nprint(B.Text)\ngame.Players.LocalPlayer.PlayerGui.MouseScript.FurniturePlacing.Value = game.ReplicatedStorage.Furniture:FindFirstChild(B.Text)\nend)\nend");
        }

        private void FlatButton11_Click(object sender, EventArgs e)
        {
            this.api.SendLimitedLuaScript("local ScreenGui = Instance.new('ScreenGui')\nlocal Holder = Instance.new('Frame')\nlocal Title = Instance.new('TextLabel')\nlocal TitleDrop = Instance.new('TextLabel')\nlocal ScrollingFrame = Instance.new('ScrollingFrame')\nlocal Title2 = Instance.new('TextLabel')\nlocal Title2Drop = Instance.new('TextLabel')\nScreenGui.Parent = game.Players.LocalPlayer.PlayerGui\nHolder.Name = 'Holder'\nHolder.Parent = ScreenGui\nHolder.Active = true\nHolder.AnchorPoint = Vector2.new(0, 0.5)\nHolder.BackgroundColor3 = Color3.new(0.298039, 0.298039, 0.298039)\nHolder.BorderSizePixel = 0\nHolder.Draggable = true\nHolder.Position = UDim2.new(0, 25, 0.5, 0)\nHolder.Size = UDim2.new(0, 150, 0, 290)\nTitle.Name = 'Title'\nTitle.Parent = Holder\nTitle.BackgroundColor3 = Color3.new(1, 1, 1)\nTitle.BackgroundTransparency = 1\nTitle.Size = UDim2.new(0, 150, 0, 10)\nTitle.ZIndex = 2\nTitle.Font = Enum.Font.SourceSansBold\nTitle.FontSize = Enum.FontSize.Size14\nTitle.Text = 'ROCITIZEN ITEM'\nTitle.TextColor3 = Color3.new(.1, 1, 1)\nTitle.TextSize = 14\nTitle.TextYAlignment = Enum.TextYAlignment.Top\nScrollingFrame.Parent = Holder\nScrollingFrame.AnchorPoint = Vector2.new(0.5, 0.5)\nScrollingFrame.BackgroundColor3 = Color3.new(0.196078, 0.196078, 0.196078)\nScrollingFrame.BorderSizePixel = 0\nScrollingFrame.Position = UDim2.new(0.5, 0, 0, 155)\nScrollingFrame.Size = UDim2.new(0, 140, 0, 250)\nScrollingFrame.BottomImage = 'rbxassetid://985424344'\nScrollingFrame.CanvasSize = UDim2.new(0, 0, 0, 0)\nScrollingFrame.MidImage = 'rbxassetid://985424344'\nScrollingFrame.ScrollBarThickness = 3\nScrollingFrame.TopImage = 'rbxassetid://985424344'\nTitle2.Name = 'Title2'\nTitle2.Parent = Holder\nTitle2.BackgroundColor3 = Color3.new(1, 1, 1)\nTitle2.BackgroundTransparency = 1\nTitle2.Position = UDim2.new(0, 0, 0, 10)\nTitle2.Size = UDim2.new(0, 150, 0, 10)\nTitle2.ZIndex = 2\nTitle2.Font = Enum.Font.SourceSansBold\nTitle2.FontSize = Enum.FontSize.Size14\nTitle2.Text = 'PAINTING SPAWNER GUI'\nTitle2.TextColor3 = Color3.new(.1, 1, 1)\nTitle2.TextSize = 14\nTitle2.TextYAlignment = Enum.TextYAlignment.Top\n \n--main script--\n \nlocal frameitems = {\n}\n \nlocal gg = game.ReplicatedStorage.PaintingCatalog:GetChildren()\nfor i = 1,#gg do\ntable.insert(frameitems,gg[i].Name)\n \nend\n \nlocal frame = ScrollingFrame\nfor i=1, #frameitems do\nlocal B = Instance.new('TextButton')\nlocal V = Instance.new('StringValue', B)\nV.Value = string.sub(frameitems[i], 7)\nB.Name = 'B'\nB.Parent = frame\nB.BackgroundColor3 = Color3.new(0.282353, 0.282353, 0.282353)\nB.BorderSizePixel = 0\nB.Position = UDim2.new(0, 3, 0, (((i-1)*22)+(3*i)))\nB.Size = UDim2.new(0, 134, 0, 22)\nB.Font = Enum.Font.SourceSansBold\nB.FontSize = Enum.FontSize.Size14\nB.Text = frameitems[i]\nB.TextColor3 = Color3.new(.1, .5, .5)\nB.TextScaled = true\nB.TextSize = 20\nframe.CanvasSize = UDim2.new(0,0,0,(#frameitems*22+(i*3)+3))\nB.MouseButton1Down:connect(function()\nprint(B.Text)\ngame.Players.LocalPlayer.PlayerGui.MouseScript.FurniturePlacing.Value = game.ReplicatedStorage.PaintingCatalog:FindFirstChild(B.Text)\nend)\nend");
        }

        private void FlatButton12_Click(object sender, EventArgs e)
        {
            string Money = textBox1.Text;
            this.api.SendScript("getglobal game\ngetfield -1 Players\ngetfield -1 LocalPlayer\ngetfield -1 ChangeMoney\ngetfield -1 Fire\npushvalue -2\npushnumber " + Money + "\npcall 2 1 0");
        }

        private void FlatButton13_Click(object sender, EventArgs e)
        {
            this.api.SendLimitedLuaScript("game.Workspace.Events.TycoonItems.PurchaseGemItem:InvokeServer(-100000000, 'G12')");
        }

        private void FlatButton14_Click(object sender, EventArgs e)
        {
            this.api.SendLimitedLuaScript("if game.Workspace.Map:FindFirstChild('Office') then\n \n \nfor i,v in pairs(game.Workspace.Map.Office.Objects:GetChildren()) do\nif v:IsA('Model') then\nv.Handle.CFrame = game.Players.LocalPlayer.Character.HumanoidRootPart.CFrame\nend\nend\n \nelse\n \nif game.Workspace.Map:FindFirstChild('House') then\nfor i,v in pairs(game.Workspace.Map.House.Objects:GetChildren()) do\nif v:IsA('Model') then\nv.Handle.CFrame = game.Players.LocalPlayer.Character.HumanoidRootPart.CFrame\nend\nend\nend\nend\n \nif game.Workspace.Map:FindFirstChild('School') then\nfor i,v in pairs(game.Workspace.Map.School.Objects:GetChildren()) do\nif v:IsA('Model') then\nv.Handle.CFrame = game.Players.LocalPlayer.Character.HumanoidRootPart.CFrame\nend\nend\nend");
        }

        private void FlatButton15_Click(object sender, EventArgs e)
        {
            this.api.SendLimitedLuaScript("local A_1 =\n{\n['Rarity'] = 0,\n['AnglesXYZ'] =\n{\n['Y'] = 0,\n['X'] = 0,\n['Z'] = 0\n},\n['id'] = 1002,\n['Name'] = 'Iron Bat',\n['Model'] = game:GetService('ReplicatedStorage').Models.Weapons.IronBat,\n['Cost'] = -1000000000,\n['CFrameXYZ'] =\n{\n['Y'] = 0,\n['X'] = 0,\n['Z'] = 0\n},\n['Icon'] = 'rbxassetid://1826666844',\n['Typeid'] = 1\n}\nlocal Event = game:GetService('ReplicatedStorage').Events.Buy\nEvent:InvokeServer(A_1)");
        }

        private void FlatButton16_Click(object sender, EventArgs e)
        {
            this.fastColoredTextBox1.Clear();
        }

        private void FlatButton17_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                FileName = "",
                Filter = "Text Files|*.txt |All Files (*.*)|*.*"
            };
            bool flag = openFileDialog.ShowDialog() == DialogResult.OK;
            if (flag)
            {
            }
            this.fastColoredTextBox1.Text = File.ReadAllText(openFileDialog.FileName);
        }
    }
}
