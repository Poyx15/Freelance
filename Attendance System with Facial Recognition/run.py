import tkinter as tk
import test1
import subprocess
import pi_face_recognition
import build_face_dataset
import encode_faces
import attendance_log

HEIGHT = 600
WIDTH = 800
root = tk.Tk()
root.title('Attendance System')
#### main:

class GraphicInterface:
    
    def __init__(self, master):
        self.master = master
        self.myFrame = tk.Frame(master)
        self.myFrame.pack()

        self.canvas = tk.Canvas(master, height=HEIGHT, width=WIDTH)
        self.canvas.pack()
        
        self.background_image = tk.PhotoImage(file='landscape.png')
        self.background_label = tk.Label(self.canvas, image=self.background_image)
        self.background_label.place(relwidth=1, relheight=1)

        self.frame1 = tk.Frame(self.canvas, bg="#6699ff", bd=5)
        self.frame1.place(relx=0.5, rely=0.1, relwidth=0.75, relheight=0.1, anchor='n')
        
        self.buttonDetect = tk.Button(self.frame1, text='Run Detection', font=('Courier', 14), highlightcolor='red', command=self.OpenDetection)
        self.buttonDetect.place(relx=0.05, rely=0.15, relheight=.70, relwidth=0.25)
        
        self.buttonEmbed = tk.Button(self.frame1, text='Upd Embed', font=('Courier', 14), highlightcolor='red', command=self.UpdateEmbeddings)
        self.buttonEmbed.place(relx=0.35, rely=0.15, relheight=.70, relwidth=0.25)
        
        self.buttonGenerateReport = tk.Button(self.frame1, text='Report', font=('Courier', 14), highlightcolor='red', command=self.GenerateReport)
        self.buttonGenerateReport.place(relx=0.65, rely=0.15, relheight=.70, relwidth=0.25)
        
        self.frame2 = tk.Frame(self.canvas, bg="#6699ff", bd=5)
        self.frame2.place(relx=0.5, rely=0.25, relwidth=0.75, relheight=0.1, anchor='n')
        
        self.label2 = tk.Label(self.frame2, text="Name: ", font=('Courier', 14), justify='right')
        self.label2.place(relx=0.05, rely=.15, relheight=.70, relwidth=0.25)
        
        self.entryName = tk.Entry(self.frame2, font=('Courier', 14))
        self.entryName.place(relx=0.35, rely=.15, relheight=.70, relwidth=0.25)
        
        self.buttonAddPerson = tk.Button(self.frame2, text='Add Person', font=('Courier', 14), highlightcolor='red', command=self.AddPerson)
        self.buttonAddPerson.place(relx=0.65, rely=0.15, relheight=.70, relwidth=0.25)
        
        
        
    def OpenDetection(self):
        pi_face_recognition.execall()
        
    def UpdateEmbeddings(self):
        encode_faces.update_faces()
        
    def AddPerson(self):
        name = self.entryName.get()
        build_face_dataset.add_user(name)
        self.entryName.delete(0, 'end')
        
    def GenerateReport(self):
        attendance_log.generate_logs()
        
        
#### run the main loop
if __name__ == '__main__':
    App = GraphicInterface(root)
    
    root.mainloop()
