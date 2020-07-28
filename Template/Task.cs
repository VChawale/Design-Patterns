namespace Design_Patterns.Template
{
    public abstract class Task
    {
        private AuditTrail auditTrail = new AuditTrail();

        public Task()
        {
            auditTrail = new AuditTrail();
        }
        public Task(AuditTrail auditTrail)
        {
            this.auditTrail = auditTrail;
        }
        public void execute()
        {
            auditTrail.Record();
            doExecute();
        }

        protected abstract void doExecute();
    }
}