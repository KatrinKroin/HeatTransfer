using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace heat
{
    public partial class Form1 : Form
    {
        string[] materials = { "Acetals", "Acetone", "Acetylene(gas)", "Acrylic", "Air, atmosphere(gas)", "Air, elevation 10000 m",
            "Agate", "Alcohol", "Aluminum", "Aluminum Brass", "Aluminum Oxide", "Ammonia(gas)", "Antimony", "Apple(85.6% moisture)",
            "Argon(gas)", "Asbestos-cement board","Asbestos-cement sheets",	"Asbestos-cement",	"Asbestos, loosely packed",
            "Asbestos mill board","Asphalt","Balsa wood","Bitumen","Bitumen/felt layers","Benzene","Beryllium","Bismuth","Bitumen",
            "Blast furnace gas(gas)" ,"Brass","Brick dense","Brick, fire","Brick, insulating","Brickwork, dense","Bromine(gas)","Bronze",
            "Brown iron ore	","Butter(15% moisture content)","Cadmium","Calcium silicate","Carbon","Carbon dioxide(gas)","Carbon monoxide",
            "Cast iron","Cellulose, cotton, wood pulp and regenerated",
            "Cement, portland","Cement, mortar","Chalk","Charcoal","Chlorinated poly-ether","Chlorine(gas)","Chrome Nickel Steel(18% Cr, 8 % Ni)" ,
            "Chromium","Chrom-oxide","Coal","Cobalt","Cod(83% moisture content)","Coke","Concrete, stone","Constantan","Copper"
,"Corian(ceramic filled)"
,"Cork board"
,"Cork, re-granulated"
,"Cork"
,"Cotton"
,"Cotton wool"
,"Carbon Steel"
,"Cotton Wool insulation"
,"Diamond"
,"Diatomaceous earth(Sil-o-cel)"
,"Diatomite"
,"Duralium"
,"Earth, dry"
,"Ebonite"
,"Emery"
,"Engine Oil"
,"Ethane(gas)"
,"Ether"
,"Ethylene(gas)"
,"Epoxy"
,"Ethylene glycol"
,"Feathers"
,"Felt insulation"
,"Fiberglass"
,"Fiber insulating board"
,"Fiber hardboard"
,"Fire-clay brick 500oC"
,"Fluorine(gas)"
,"Foam glass"
,"Dichlorodifluoromethane R-12 (gas)"
,"Dichlorodifluoromethane R-12 (liquid)	"
,"Gasoline"
,"Glass"
,"Glass, Pearls, dry"
,"Glass, Pearls, saturated"
,"Glass, window"
,"Glass, wool Insulation"
,"Glycerol"
,"Gold"
, "Graphite"
, "Gravel"
, "Ground or soil, very moist area	"
, "Ground or soil, moist area"
, "Ground or soil, dry area"
, "Ground or soil, very dry area"
, "Gypsum board"
, "Hairfelt"
, "Hardboard high density"
, "Hardwoods(oak, maple..)"
, "Helium(gas)"
, "Honey(12.6% moisture content)"
, "Hydrochloric acid(gas) "
, "Hydrogen(gas)"
, "Hydrogen sulfide(gas)"
, "Ice(0oC, 32oF)"
, "Iodine"
, "Iridium"
, "Iron"
, "Iron, wrought"
, "Iron, cast"
, "Iron-oxide"
, "Kapok insulation"
, "Kerosene"
, "Krypton(gas)"
, "Lead Pb"
, "Leather, dry"
,"Lithium"
,"Magnesia insulation(85%)"
,"Magnesite"
,"Magnesium"
,"Marble"
,"Mercury, liquid"
,"Methane(gas)"
,"Methanol"
,"Mica"
,"Milk"
,"Mineral wool insulation materials, wool blankets.."
,"Molybdenum"
,"Monel"
,"Neon(gas)"
,"Neoprene"
,"Nickel"
,"Nitric oxide(gas)"
,"Nitrogen(gas)"
,"Nitrous oxide(gas)"
,"Nylon 6, Nylon 6/6"
,"Oil, machine lubricating SAE 50"
,"Olive oil"
,"Oxygen(gas)"
,"Palladium	"
,"Paper"
,"Paraffin Wax"
,"Peat"
,"Perlite, atmospheric pressure"
,"Perlite, vacuum"
,"Phenolic cast resins"
,"Phenol-formaldehyde moulding compounds"
,"Phosphorbronze"
,"Pinchbeck"
,"Pitch"
,"Pit coal"
,"Plaster light"
,"Plaster, metal lath"
,"Plaster, sand"
,"Plaster, wood lath"
,"Plasticine"
,"Plastics, foamed(insulation materials)"
,"Platinum"
,"Plutonium	"
,"Plywood"
,"Polycarbonate"
,"Polyester"
,"Polyethylene low density, PEL"
,"Polyethylene high density, PEH"
,"Polyisoprene natural rubber"
,"Polyisoprene hard rubber"
,"Polymethylmethacrylate"
,"Polypropylene, PP"
,"Polystyrene, expanded styrofoam"
,"Polystyrol"
,"Polyurethane foam"
,"Porcelain"
,"Potassium	"
,"Potato, raw flesh"
,"Propane(gas)"
,"Polytetrafluoroethylene(PTFE)"
,"Polyvinylchloride, PVC"
,"Pyrex glass"
,"Quartz mineral"
,"Radon(gas)"
,"Red metal"
,"Rhenium"
,"Rhodium"
,"Rock, solid"
,"Rock, porous volcanic(Tuff)"
,"Rock Wool insulation"
,"Rosin"
,"Rubber, cellular"
,"Rubber, natural"
,"Rubidium"
,"Salmon(73% moisture content)"
,"Sand, dry"
,"Sand, moist"
,"Sand, saturated"
,"Sandstone"
,"Sawdust"
,"Selenium"
,"Sheep wool"
,"Silica aerogel"
,"Silicon cast resin"
,"Silicon carbide"
,"Silicon oil"
,"Silver"
,"Slag wool"
,"Slate"
,"Snow(temp< 0oC)"
,"Sodium"
,"Softwoods(fir, pine..)"
,"Soil, clay"
,"Soil, with organic matter"
,"Soil, saturated"
,"Soot"
,"Steam, saturated"
,"Steam, low pressure"
,"Steatite"
,"Steel, Carbon 1%"
,"Stainless Steel"
,"Straw slab insulation, compressed"
,"Styrofoam"
,"Sulfur dioxide(gas)"
,"Sulfur, crystal"
,"Sugars"
,"Tantalum"
,"Tar"
,"Tellurium"
,"Thorium"
,"Timber, alder"
,"Timber, ash"
,"Timber, birch"
,"Timber, larch"
,"Timber, maple"
,"Timber, oak"
,"Timber, pitchpine"
,"Timber, pockwood"
,"Timber, red beech"
,"Timber, red pine"
,"Timber, white pine"
,"Timber, walnut"
,"Tin Sn"
,"Titanium"
,"Tungsten"
,"Uranium"
,"Urethane foam"
,"Vacuum"
,"Vermiculite granules"
,"Vinyl ester"
,"Water"
,"Water, vapor(steam)"
,"Wax"
,"Wheat flour"
,"White metal"
,"Wood across the grain, white pine"
,"Wood across the grain, balsa"
,"Wood across the grain, yellow pine, timber"
,"Wood, oak"
,"Wool, felt"
,"Wood wool, slab"
,"Xenon(gas)"
,"Zinc Zn"

        };




        double[] coefs={0.23,0.16,0.018,0.2,0.024,0.020,10.9,0.17,205,121,30,0.022,18.5,0.39,0.016,0.744,
                        0.166,2.07,	0.15,0.14,0.75,0.048,0.17,0.5,0.16,218,	8.1	,0.17,
                        0.02,109,1.31,0.47,0.15,1.6,0.004,110,0.58,0.20	,92.1,0.05,1.7,0.0146,0.0232,58,0.23,
	                    0.29,1.73,0.09,0.084,0.13,0.0081,16.3,94,0.42,0.2,69,0.54,0.184,	
                        1.7,23.3,401,1.06,0.043,0.044,0.07,0.04,0.029,54,0.029,1000,0.06,0.12,129,1.5,0.17,11.6,0.15,
                        0.018,0.14,0.017,0.35,0.25,0.034,0.04,0.04,
                        0.048,0.2,1.4,0.0254,0.045,0.007,0.09,0.15,1.05,0.18,0.76,0.96,0.04,0.28,310,
                        168,0.7,1.4,1.0,0.5,0.33,0.17,0.05,0.15,0.16,0.142,0.5,0.013,0.168,0.013,2.18,0.44,147,80,59,55,0.58,0.034,0.15,0.0088,35,0.14,
                        301,0.07,4.15,156,2.08,8.3,0.030,0.21,0.71,0.53,0.04,138,26,0.046,0.05,91,0.0238,0.024,0.0151,0.25,0.15,0.17,0.024,70.9,0.05,0.25,0.08,    
                        0.031,0.00137,0.15,0.13,110,159,0.13,0.24,0.2,0.47,0.71,0.28,0.65,0.03,70,6.7,0.13,0.19,0.05,0.33,0.42,0.13,0.16,0.17,0.1,0.03,0.043,0.03,1.5,1,
                        0.55,0.015,0.25,0.19,1.005,3,0.0033,128,71,88,2,0.5,0.045,0.32,0.045,0.13,58,0.50,0.15,0.25,2,1.7,0.08,0.2,0.039,0.02,0.15,15.2,0.1,429,  
                        0.042,2.01,0.05 ,135,0.12,1.1,0.15,0.6,0.07,0.0184,0.0188,2,43,16,0.09,0.033,0.0086,0.2,0.087,54,0.19,4.9,38,0.17,0.16,0.14,0.12,0.16,0.17,
                        0.14,0.19,0.14,0.15,0.15,0.15,67,22,174,27.6,0.021,0,0.065,0.25,0.58,0.016,0.084,0.45,35,0.12,0.055,0.147,0.17,0.07,0.1,0.0051,116
        };



        public Form1()
        {
            InitializeComponent();
            Material.Items.AddRange(materials);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //autofill of fields

            Left.Text = "10";
            Right.Text = "45";
            Width.Text = "13";
            Time.Text = "15";
            Middle.SelectedItem = Middle.Items[0];
            Material_alt.Text = "0.6";
            MiddleTemp.Text = "30";

            //---------------------------------

        }

        private void Material_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = Material.Items.IndexOf(Material.SelectedItem);
            Material_alt.Text = coefs[index].ToString();
        }

        private void Material_alt_TextChanged(object sender, EventArgs e)
        {
            Material.ResetText();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (Verify_Fields() == true)
            {

                this.Visible = false;
                Form2 form2 = new Form2(int.Parse(Left.Text.ToString()), int.Parse(Right.Text.ToString()), int.Parse(Width.Text.ToString()), int.Parse(Time.Text.ToString()), Middle.SelectedItem, int.Parse(MiddleTemp.Text.ToString()), float.Parse(Material_alt.Text.ToString()));
                Application.EnableVisualStyles();
                form2.ShowDialog();
                this.Visible = true;

            }
         
        }


        private bool Verify_Fields() {
            int l;
            float c;

            if (int.TryParse(Left.Text, out l) == false)
            {
                MessageBox.Show("First temperature must be integer number");
                return false;
            }

      
            if (int.TryParse(Right.Text, out l) == false)
            { 
                MessageBox.Show("Second temperature must be integer number");
                return false;
            }

            if (int.TryParse(Width.Text, out l) == false)
            {
                MessageBox.Show("Width must be integer number");
                return false;
            }


            if (int.TryParse(Time.Text, out l) == false)
            {
                MessageBox.Show("Time must be integer number");
                return false;
            }

            if (int.TryParse(MiddleTemp.Text, out l) == false)
            {
                MessageBox.Show("Starting temperature must be integer number");
                return false;
            }

            if (Middle.SelectedItem == null)
            {
                MessageBox.Show("Starting temperature function must be selected");
                return false;
            }


            if (Material_alt.Text == "")
            {
                MessageBox.Show("Heat transfer coefficient must be selected");
                return false;
            }

            if (float.TryParse(Material_alt.Text, out c) == false)
            {
                MessageBox.Show("Heat transfer coefficient must numeric");
                return false;
            }


            return true;
        }

    }
}
