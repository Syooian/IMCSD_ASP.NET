���DBFirst_Test���ҰʱM��
�M��޲z�D���x���w�]�M�׿��DBFirst_Test
Scaffold-DbContext�ͦ�Model�ާ@�G\
Scaffold-DbContext "Server='127.0.0.1';Database='dbstudents';User='root';Password='autc007'" Pomelo.EntityFrameworkCore.MySql -OutputDir Models -NoOnConfiguring -UseDatabaseNames -NoPluralize -Force

## �ͦ�Model�ɦ۰ʥ[�J����
��Ʈw�W�p�G����J���ѡA�ͦ�Model�ɷ|�۰ʥ[�J����

<p><img alt="��" title="Comm1" src="Comm1.jpg" /></p>
<p><img alt="��" title="Comm2" src="Comm2.jpg" /></p>
<p><img alt="��" title="Comm3" src="Comm3.jpg" /></p>

<p>���s�ͦ�Model�ɡA������Model�ɮסA�_�h���|�����X��ƪ�W���ܰ�</p>
e.g. ��ƪ�W�s�W�F���A�ݥ��N������Model�ɮ������A�A���s����Scaffold-DbContext�AModel�ɤ~�|�]�X�s������ݩ�

## �����ҳW�h�M��ܦW�ٿW�ߡA�קK�۰ʭ��s�ͦ�Model�ɳQ�л\
<h3>1. �ϥγ������O�]Partial Classes�^</h3>
EF Core �ͦ����ҫ��q�`�O partial ���O�A�o���\�z�b�t�@���ɮפ��X�i�����O�A�Ӥ��|�Q���s�ͦ����ҫ��л\�C

<p>��{�B�J�G</p>
<ol>
	<li>�Ыؤ@�ӷs���������O�ɮסG �b�P�ҫ��ۦP���R�W�Ŷ����Ыؤ@�ӷs���ɮסA�Ҧp tstudent2.Metadata.cs�C</li>
	<li>�w�q�������O�����Τ��ƾ����O�G �ϥ� [MetadataType] �ݩʱN��ܦW�٩M���ҳW�h���ʨ줸�ƾ����O���C</li>
</ol>
	
<h3>2. ���ƾ����O����{</h3>
���ƾ����O�Ω�w�q��ܦW�٩M���ҳW�h�A�ûP�ҫ����O�����C

<h3>3. �u��</h3>
<ul>
	<li>�קK�л\�G���s�ͦ��ҫ��ɡA���ƾ����O���|�Q�v�T�C</li>
	<li>�������`�I�G��ܦW�٩M���ҳW�h�P�ҫ��޿�����A�N�X��M���C</li>
	<li>������@�G�i�H��W�ק露�ƾ����O�A�Ӥ��v�T�ҫ�����L�����C</li>
</ul>

<h3>4. �`�N�ƶ�</h3>
<ol>
	<li>�R�W�Ŷ��@�P�G �T�O���ƾ����O�P�ҫ����O�b�ۦP���R�W�Ŷ����A�_�h [MetadataType] �ݩʵL�k���T���ΡC</li>
	<li>EF Core ����������ͦ����ƾ����O�G �z�ݭn��ʳЫؤ��ƾ����O�A�o�O�קK�л\���N���C</li>
	<li>���ҳW�h�����ΡG �T�O Razor Pages �α�������ҫ��j�w�M�����޿西�T���γo�ǳW�h�C</li>
</ol>

<h3>�`��</h3>
�q�L�ϥ� �������O �M ���ƾ����O�A�z�i�H�N��ܦW�٩M���ҳW�h�q�ҫ��������A�קK�b���s�ͦ��ҫ��ɳQ�л\�C�o�O�@�ؼзǥB���˪����k�A�S�O�O�b�ϥ� EF Core �� DB First �}�o�Ҧ��ɡCBy GitHub Copilot
