namespace Design_Patterns.State
{
    public class Canvas
    {
        private ITool currentTool;

        public ITool GetCurrentTool()
        {
            return currentTool;
        }
        
        public void SetCurrentTool(ITool currentTool)
        {
            this.currentTool = currentTool;
        }

        public void MouseDown(){

            currentTool.MouseDown();
        }

        public void MouseUp(){

            currentTool.MouseUp();
        }
    }
}