
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComiLib;
//using ComiLib.GCode;
using System.IO;

namespace EtherCAT_Examples_CSharp
{
    public partial class formGCode : Form
    {
        /*
        public formGCode()
        {
            InitializeComponent();
            ComiSys.DeviceLoad(DevType.EtherCAT);
        }

        GProject project; // GCode용 프로젝트 파일
        GInterpreter interpreter;


        // 프로젝트 생성과 컴파일은 ComiIDE 로 대체할 수 있다.
        // https://winoar.com/dokuwiki/application:comiide:tool:scripter:10_gcode:start 참조

        // CAD 파일을 GCode 로 변경하는 방법은 
        // https://winoar.com/dokuwiki/application:comiide:tool:scripter:10_gcode:21_cadtogcode 참조


        /// <summary>
        /// 프로젝트 생성
        /// </summary>
        void MakeNewProject()
        {
            string projectName = "GCodeTest";
            project = new GProject(projectName);

            // GCode 파일들이 포함된 디렉토리 경로를 ProjectPath 로 설정한다.                        
            // 설정 시, gcode 파일이 project의 fileInfoList 변수 안에 포함된다.
            project.ProjectPath = string.Format(@"{0}\Data\GCodeTest", Application.StartupPath);
            project.ProjectType = Enums.ProjectType.G;
        }

        /// <summary>
        /// Interpreter에서 사용할 목적 파일을 생성
        /// </summary>
        /// <returns></returns>
        bool Compile()
        {
            if (project == null)
                return false;

            if (new DirectoryInfo(project.ProjectPath).GetFiles().Count() == 0)
                return false;
            
            // 컴파일러와 프로젝트를 연결한다.
            GCompiler.T.SetProject(project);

            // Compile 실행
            // 목적 파일은 Project.OutputFilePath 경로에 생성된다.
            // Project.OutputFilePath 는 Project.ProjectPath 생성 시 bin 폴더에 projectName.gpf 로 자동 생성되며, 변경할 수 있다.
            bool isCompt = GCompiler.T.Compile();

#if false //CSharp
            var errorList = GCompiler.T.compileErrorList.FindAll(x => x.type.Equals(GCompiler.ErrorType.Error));
            var warningList = GCompiler.T.compileErrorList.FindAll(x => x.type.Equals(GCompiler.ErrorType.Warning));

#else
            // isCompt가 false라면, Compile 시 발생 한 Error 와 Warning을 확인한다.
            var errorMsgs = GCompiler.T.GetCompileErrorMsgs();
            var warnMsgs = GCompiler.T.GetCompileWarningMsgs();
#endif
            return isCompt;
        }

        void LoadProject()
        {
            // 목적 파일이 있다면, Load하여 바로 사용할 수 있다. 
            // Make Project와 Compile은 목적 파일을 만들기 위한 과정이므로, 최초 1회만 실행한다.
            string projectFilePath = string.Format(@"{0}\Data\GCodeTest\bin\GCodeTest.gpf", Application.StartupPath);
            if (File.Exists(projectFilePath))
                project = new GProject().Load(projectFilePath);
            else
                MessageBox.Show("File이 없습니다.");
        }

        
        void Run()
        {
            if (project == null)
                LoadProject();

            int axisMask = 3; // 이송에 포함되는 축의 mask. 0,1,2 번 축 포함 시 7
            interpreter = new GInterpreter(project, axisMask);
            interpreter.Init();
            interpreter.Start();
        }


        void Stop()
        {
            if (interpreter != null)
                interpreter.Stop();
        }


        void Pause()
        {
            if (interpreter != null)
                interpreter.Pause();
        }


        private void btnMakeProject_Click(object sender, EventArgs e)
        {
            MakeNewProject();
        }

        private void btnCompile_Click(object sender, EventArgs e)
        {
            Compile();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Run();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            Pause();
        }
        */
    }
}
