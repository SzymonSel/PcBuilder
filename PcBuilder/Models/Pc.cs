namespace PcBuilder.Models {
    public class Pc {
        public Psu Psu { get; set; }
        public Ram Ram { get; set; }
        public Cpu Cpu { get; set; }
        public Component[] OtherComponents { get; set; }

        public Pc(Cpu cpu, Psu psu, Ram ram) {
            this.Cpu = cpu;
            this.Psu = psu;
            this.Ram = ram;
        }


        public bool HasRequiredComponents() {
            return (this.Ram != null && this.Cpu != null && this.Psu != null);
        }

        public bool HasPostivePowerBalance() {
            int powerBallance = 0;

            powerBallance += this.Cpu.Power + this.Psu.Power + this.Ram.Power;
            if (this.OtherComponents != null) {
                for (int i = 0; i < this.OtherComponents.Length; i++) {
                    powerBallance += this.OtherComponents[i].Power;
                }
            }

            return powerBallance >= 0;
        }
    }
}