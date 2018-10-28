Development of an application for Virtual Surgical Planning

Craniosynostosis, a congenital conditions causing premature skull bone fusion in children, leads to abnormal development of the skull and mid-face. Craniofacial surgery deals with congenital and acquired deformities of the head, skull, face, jaws and associated structures and aims at restoring normal appearance.
The advent of virtual surgical planning (VSP) has offered an alternative workflow for more precise preoperative planning and a decreased necessity for intraoperative trial and error: surgeons can now plan bony cuts on a computer screen and decide how to move and bend bones in order to restore normal appearance for children affected by craniosynostosis.
Commercial software allow planning for the most common craniofacial surgeries but are limited when it comes to design new techniques; furthermore most commercial programs work off workstations although graphics and computational demand could be dealt with by an iPad. 
The aim of this project is to create a simple but flexible graphic application which will import patient anatomical data in the form of STL (StereoLithography) files and will allow the surgeon to simulate bony cuts, split the anatomy into parts, rearrange them  and this way simulate the outcome of surgery. 

Patients: Children in age range 0-2 with Craniosynostosis. When Sutures become bone too quickly. Cases differ depending on syndrome and age.

Reasons to do surgery:
Deformed skull: to give better shape visually
Skull shape that puts pressure on brain or other organs as there is not enough volume 

Problem to solve: 
Optimize procedure outcome by predicting where should skull cuts be made and how skull should be reshaped by repositioning skull cuts
Eliminate risks of injuries by calculating cut size limits and dangerous areas for cutting

Other Essential Functionalities:
Identify leftovers after operation
Calculating exact skull dimensions and volume increase/decrease after procedure.
Visualize outcomes so parents can see it in advance, this will also allow them to choose between different shapes as now they 100% rely on doctors
Understand maximum gap size between cuts if there is not enough bone (happens when size is increased)
Visualize outcomes using overlaying augmented reality display on patients skull (Alternative was 3d printed cutting guides but AR is preferred) 
If input falls into normal frequency of deformed skull shapes, program should show standard/traditional solutions, however, it should also be able to do personalized calculations for rare cases

Machine learning model: 
Input:
CT Scans/Images → this information can be used to make 3d reconstruction of skull
Historical data of healthy and unhealthy skulls 
Operation results and durations
Doctors Input (which can physical measurements of the skull recorded by doctor or any other decisions)

Output: 
Procedure time
Procedure outcomes
Skull physical dimensions
Volume increase/decrease in the skull
Shape
Visual data that should be passed to hololens → Displays holographic image on patients head during operation

Prediction Algorithm Sketch: 


