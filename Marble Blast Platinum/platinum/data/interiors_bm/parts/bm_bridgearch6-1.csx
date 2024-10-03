<?xml version="1.0" encoding="utf-8" standalone="yes" ?>
<!--Torque Constructor Scene document http://www.garagegames.com-->
<ConstructorScene version="4" creator="Torque Constructor" date="2024/10/03 00:12:44">
    <Sunlight azimuth="180" elevation="35" color="255 255 255" ambient="64 64 64" />
    <LightingOptions lightingSystem="" ineditor_defaultLightmapSize="256" ineditor_maxLightmapSize="256" ineditor_lightingPerformanceHint="0" ineditor_shadowPerformanceHint="1" ineditor_TAPCompatibility="0" ineditor_useSunlight="0" export_defaultLightmapSize="256" export_maxLightmapSize="256" export_lightingPerformanceHint="0" export_shadowPerformanceHint="1" export_TAPCompatibility="1" export_useSunlight="0" />
    <GameTypes>
        <GameType name="Constructor" />
        <GameType name="Torque" />
    </GameTypes>
    <DetailLevels current="0">
        <DetailLevel minPixelSize="0" actionCenter="0 0 0">
            <InteriorMap brushScale="32" lightScale="8" ambientColor="0 0 0" ambientColorEmerg="0 0 0">
                <Entities nextEntityID="1">
                    <Entity id="0" classname="worldspawn" gametype="Torque" isPointEntity="0">
                        <Properties detail_number="0" min_pixels="250" geometry_scale="32" light_geometry_scale="8" ambient_color="0 0 0" emergency_ambient_color="0 0 0" mapversion="220" />
                    </Entity>
                </Entities>
                <Brushes nextBrushID="40">
                    <Brush id="0" owner="0" type="0" pos="-5.7643 5.99534 0" rot="1 0 0 0" scale="" transform="1 0 0 -5.7643 0 1 0 5.99534 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.23539 -0.00465631 1" />
                            <Vertex pos="-0.235733 0.00465584 1" />
                            <Vertex pos="0.23539 -0.00465631 -1" />
                            <Vertex pos="-0.235733 0.00465584 -1" />
                            <Vertex pos="0.235733 0.00465584 1" />
                            <Vertex pos="0.235733 0.00465584 -1" />
                        </Vertices>
                        <Face id="0" plane="-0.019762 -0.999805 -0 -3.63076e-006" album="" material="BM_GRID_BLANK4" texgens="0.996919 -0.0784383 0 31.9995 0 0 -1 128 0 0.235378 0.25" texRot="0" texScale="0.235378 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -0 1 -1" album="" material="BM_GRID_BLANK4" texgens="1 0 0 30.1759 0 -1 0 -1535.4 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -1" album="" material="BM_GRID_BLANK4" texgens="-1 0 0 -30.1759 0 -1 0 -1535.4 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 3 2" />
                        </Face>
                        <Face id="3" plane="0.999321 -0.0368432 0 -0.235401" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0 1 0 383.851 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 0 4" />
                        </Face>
                        <Face id="4" plane="0 1 0 -0.00465584" album="" material="BM_GRID_BLANK4" texgens="-1 0 0 17.5825 0 0 1 127.878 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 4 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="1" owner="0" type="0" pos="-5.29227 5.9815 0" rot="1 0 0 0" scale="" transform="1 0 0 -5.29227 0 1 0 5.9815 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.23664 0.0091877 1" />
                            <Vertex pos="0.233734 -0.0184999 1" />
                            <Vertex pos="-0.23664 0.0091877 -1" />
                            <Vertex pos="0.233734 -0.0184999 -1" />
                            <Vertex pos="-0.236297 0.0184999 1" />
                            <Vertex pos="0.23664 0.0184999 1" />
                            <Vertex pos="-0.236297 0.0184999 -1" />
                            <Vertex pos="0.23664 0.0184999 -1" />
                        </Vertices>
                        <Face id="0" plane="-0.0587611 -0.998272 0 -0.00473343" album="" material="BM_GRID_BLANK4" texgens="0.996919 -0.0784383 0 96.1224 0 0 -1 128 0 0.235378 0.25" texRot="0" texScale="0.235378 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 1 -1" album="" material="BM_GRID_BLANK4" texgens="1 0 0 90.5958 0 -1 0 -1533.63 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 -0 -1 -1" album="" material="BM_GRID_BLANK4" texgens="-1 0 0 -90.5958 0 -1 0 -1533.63 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="-0.999321 0.0368432 0 -0.236818" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.0392608 0.999229 0 384.002 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.996928 -0.0783214 0 -0.234465" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.0392608 0.999229 0 384.002 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 1 0 -0.0184999" album="" material="BM_GRID_BLANK4" texgens="-1 0 0 22.5475 0 0 1 127.679 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="2" owner="0" type="0" pos="-4.81914 5.95841 0" rot="1 0 0 0" scale="" transform="1 0 0 -4.81914 0 1 0 5.95841 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.239391 0.00459433 1" />
                            <Vertex pos="0.229547 -0.0415931 1" />
                            <Vertex pos="-0.239391 0.00459433 -1" />
                            <Vertex pos="0.229547 -0.0415931 -1" />
                            <Vertex pos="-0.236484 0.0415931 1" />
                            <Vertex pos="0.239391 0.0415931 1" />
                            <Vertex pos="-0.236484 0.0415931 -1" />
                            <Vertex pos="0.239391 0.0415931 -1" />
                        </Vertices>
                        <Face id="0" plane="-0.0980194 -0.995185 0 -0.0188927" album="" material="BM_GRID_BLANK4" texgens="0.996919 -0.0784383 0 160.494 0 0 -1 128 0 0.235378 0.25" texRot="0" texScale="0.235378 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 1 -1" album="" material="BM_GRID_BLANK4" texgens="1 0 0 151.156 0 -1 0 -1530.68 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 -0 -1 -1" album="" material="BM_GRID_BLANK4" texgens="-1 0 0 -151.156 0 -1 0 -1530.68 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="-0.996928 0.0783234 0 -0.239015" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.0784602 0.996917 0 384.455 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.993071 -0.117515 0 -0.232844" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.0784602 0.996917 0 384.455 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 1 0 -0.0415931" album="" material="BM_GRID_BLANK4" texgens="-1 0 0 27.4125 0 0 1 127.486 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="3" owner="0" type="0" pos="-4.3445 5.92616 0" rot="1 0 0 0" scale="" transform="1 0 0 -4.3445 0 1 0 5.92616 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.245094 -0.00934362 1" />
                            <Vertex pos="0.221687 -0.0738435 1" />
                            <Vertex pos="-0.245094 -0.00934362 -1" />
                            <Vertex pos="0.221687 -0.0738435 -1" />
                            <Vertex pos="-0.23525 0.0738435 1" />
                            <Vertex pos="0.245094 0.073844 1" />
                            <Vertex pos="-0.23525 0.0738435 -1" />
                            <Vertex pos="0.245094 0.073844 -1" />
                        </Vertices>
                        <Face id="0" plane="-0.136879 -0.990588 0 -0.042804" album="" material="BM_GRID_BLANK4" texgens="0.996919 -0.0784383 0 225.166 0 0 -1 128 0 0.235378 0.25" texRot="0" texScale="0.235378 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 1 -1" album="" material="BM_GRID_BLANK4" texgens="1 0 0 211.91 0 -1 0 -1526.55 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 -0 -1 -1" album="" material="BM_GRID_BLANK4" texgens="-1 0 0 -211.91 0 -1 0 -1526.55 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="-0.993071 0.117514 0 -0.242298" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.117539 0.993068 0 385.219 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.987673 -0.156533 0 -0.230513" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.117539 0.993068 0 385.219 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="-9.927e-007 1 0 -0.0738437" album="" material="BM_GRID_BLANK4" texgens="-1 0 0 32.131 0 0 1 127.293 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="4" owner="0" type="0" pos="-3.86795 5.8847 0" rot="1 0 0 0" scale="" transform="1 0 0 -3.86795 0 1 0 5.8847 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.254858 -0.0324211 1" />
                            <Vertex pos="0.209015 -0.115296 1" />
                            <Vertex pos="-0.254858 -0.0324211 -1" />
                            <Vertex pos="0.209015 -0.115296 -1" />
                            <Vertex pos="-0.231453 0.115296 1" />
                            <Vertex pos="0.254858 0.115296 1" />
                            <Vertex pos="-0.231453 0.115296 -1" />
                            <Vertex pos="0.254858 0.115296 -1" />
                        </Vertices>
                        <Face id="0" plane="-0.175873 -0.984413 0 -0.0767386" album="" material="BM_GRID_BLANK4" texgens="0.972368 -0.233455 0 32.6622 0 0 -1 128 0 0.235379 0.25" texRot="0" texScale="0.235379 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 1 -1" album="" material="BM_GRID_BLANK4" texgens="1 0 0 272.908 0 -1 0 -1521.24 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 -0 -1 -1" album="" material="BM_GRID_BLANK4" texgens="-1 0 0 -272.908 0 -1 0 -1521.24 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="-0.987679 0.156496 0 -0.246645" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.156436 0.987688 0 386.301 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.980805 -0.19499 0 -0.227485" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.156436 0.987688 0 386.301 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 1 0 -0.115296" album="" material="BM_GRID_BLANK4" texgens="-1 0 0 36.6633 0 0 1 127.106 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="5" owner="0" type="0" pos="-3.38901 5.8342 0" rot="1 0 0 0" scale="" transform="1 0 0 -3.38901 0 1 0 5.8342 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.269927 -0.0647969 1" />
                            <Vertex pos="0.190324 -0.165797 1" />
                            <Vertex pos="-0.269927 -0.0647969 -1" />
                            <Vertex pos="0.190324 -0.165797 -1" />
                            <Vertex pos="-0.224083 0.165797 1" />
                            <Vertex pos="0.269927 0.165797 1" />
                            <Vertex pos="-0.224083 0.165797 -1" />
                            <Vertex pos="0.269927 0.165797 -1" />
                        </Vertices>
                        <Face id="0" plane="-0.214345 -0.976758 0 -0.121148" album="" material="BM_GRID_BLANK4" texgens="0.972368 -0.233455 0 97.5812 0 0 -1 128 0 0.235379 0.25" texRot="0" texScale="0.235379 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 1 -1" album="" material="BM_GRID_BLANK4" texgens="1 0 0 334.213 0 -1 0 -1514.78 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 -0 -1 -1" album="" material="BM_GRID_BLANK4" texgens="-1 0 0 -334.213 0 -1 0 -1514.78 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="-0.980805 0.194991 0 -0.252111" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.195092 0.980785 0 387.719 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.972373 -0.23343 0 -0.223768" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.195092 0.980785 0 387.719 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 1 0 -0.165797" album="" material="BM_GRID_BLANK4" texgens="-1 0 0 40.9605 0 0 1 126.924 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="6" owner="0" type="0" pos="-2.90718 5.77475 -5.96046e-008" rot="1 0 0 0" scale="" transform="1 0 0 -2.90718 0 1 0 5.77475 0 0 1 -5.96046e-008 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.291505 -0.106344 1" />
                            <Vertex pos="0.164452 -0.22525 1" />
                            <Vertex pos="-0.291505 -0.106344 -1" />
                            <Vertex pos="0.164452 -0.22525 -1" />
                            <Vertex pos="-0.211898 0.22525 1" />
                            <Vertex pos="0.291505 0.22525 1" />
                            <Vertex pos="-0.211898 0.22525 -1" />
                            <Vertex pos="0.291505 0.22525 -1" />
                        </Vertices>
                        <Face id="0" plane="-0.252345 -0.967637 0 -0.176462" album="" material="BM_GRID_BLANK4" texgens="0.972368 -0.233455 0 163.16 0 0 -1 128 0 0.235379 0.25" texRot="0" texScale="0.235379 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 1 -1" album="" material="BM_GRID_BLANK4" texgens="1 0 0 395.887 0 -1 0 -1507.17 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 -0 -1 -1" album="" material="BM_GRID_BLANK4" texgens="-1 0 0 -395.887 0 -1 0 -1507.17 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="-0.972371 0.23344 0 -0.258626" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.233447 0.97237 0 389.486 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.962456 -0.271439 0 -0.219419" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.233447 0.97237 0 389.486 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="-9.47227e-007 1 0 -0.22525" album="" material="BM_GRID_BLANK4" texgens="-1 0 0 44.9781 0 0 1 126.747 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="7" owner="0" type="0" pos="-2.42186 5.70634 0" rot="1 0 0 0" scale="" transform="1 0 0 -2.42186 0 1 0 5.70634 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.320872 -0.156843 1" />
                            <Vertex pos="0.130047 -0.293656 1" />
                            <Vertex pos="-0.320872 -0.156843 -1" />
                            <Vertex pos="0.130047 -0.293656 -1" />
                            <Vertex pos="-0.193819 0.293656 1" />
                            <Vertex pos="0.320872 0.293656 1" />
                            <Vertex pos="-0.193819 0.293656 -1" />
                            <Vertex pos="0.320872 0.293656 -1" />
                        </Vertices>
                        <Face id="0" plane="-0.290339 -0.956924 0 -0.243249" album="" material="BM_GRID_BLANK4" texgens="0.972368 -0.233455 0 229.488 0 0 -1 128 0 0.235379 0.25" texRot="0" texScale="0.235379 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 1 -1" album="" material="BM_GRID_BLANK4" texgens="1 0 0 458.008 0 -1 0 -1498.41 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 -0 -1 -1" album="" material="BM_GRID_BLANK4" texgens="-1 0 0 -458.008 0 -1 0 -1498.41 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="-0.962456 0.271439 0 -0.266252" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.271442 0.962455 0 391.62 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.951059 -0.309011 0 -0.214425" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.271442 0.962455 0 391.62 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 1 0 -0.293656" album="" material="BM_GRID_BLANK4" texgens="-1 0 0 48.6681 0 0 1 126.578 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="8" owner="0" type="0" pos="-1.9324 5.62916 0" rot="1 0 0 0" scale="" transform="1 0 0 -1.9324 0 1 0 5.62916 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.359415 -0.216469 1" />
                            <Vertex pos="0.0857872 -0.370844 1" />
                            <Vertex pos="-0.359415 -0.216469 -1" />
                            <Vertex pos="0.0857872 -0.370844 -1" />
                            <Vertex pos="-0.168587 0.370844 1" />
                            <Vertex pos="0.359415 0.370844 1" />
                            <Vertex pos="-0.168587 0.370844 -1" />
                            <Vertex pos="0.359415 0.370844 -1" />
                        </Vertices>
                        <Face id="0" plane="-0.327615 -0.944811 0 -0.322272" album="" material="BM_GRID_BLANK4" texgens="0.92388 -0.382683 0 33.8829 0 0 -1 128 0 0.235379 0.25" texRot="0" texScale="0.235379 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 1 -1" album="" material="BM_GRID_BLANK4" texgens="1 0 0 520.658 0 -1 0 -1488.53 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 -0 -1 -1" album="" material="BM_GRID_BLANK4" texgens="-1 0 0 -520.658 0 -1 0 -1488.53 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="-0.951057 0.309015 0 -0.274932" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.309019 0.951056 0 394.143 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.938189 -0.346123 0 -0.208842" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.309019 0.951056 0 394.143 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 1 0 -0.370844" album="" material="BM_GRID_BLANK4" texgens="-1 0 0 51.9796 0 0 1 126.419 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="9" owner="0" type="0" pos="-1.43804 5.54325 0" rot="1 0 0 0" scale="" transform="1 0 0 -1.43804 0 1 0 5.54325 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.408575 -0.284937 1" />
                            <Vertex pos="0.0301938 -0.456749 1" />
                            <Vertex pos="-0.408575 -0.284937 -1" />
                            <Vertex pos="0.0301938 -0.456749 -1" />
                            <Vertex pos="-0.134944 0.45675 1" />
                            <Vertex pos="0.408575 0.45675 1" />
                            <Vertex pos="-0.134944 0.45675 -1" />
                            <Vertex pos="0.408575 0.45675 -1" />
                        </Vertices>
                        <Face id="0" plane="-0.364621 -0.931156 0 -0.414296" album="" material="BM_GRID_BLANK4" texgens="0.92388 -0.382683 0 100.447 0 0 -1 128 0 0.235379 0.25" texRot="0" texScale="0.235379 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 1 -1" album="" material="BM_GRID_BLANK4" texgens="1 0 0 583.938 0 -1 0 -1477.54 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 -0 -1 -1" album="" material="BM_GRID_BLANK4" texgens="-1 0 0 -583.938 0 -1 0 -1477.54 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="-0.938188 0.346126 0 -0.284696" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.346119 0.938191 0 397.081 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.92388 -0.382681 0 -0.202685" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.346119 0.938191 0 397.081 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 1 0 -0.45675" album="" material="BM_GRID_BLANK4" texgens="-1 0 0 54.8594 0 0 1 126.27 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="10" owner="0" type="0" pos="-0.937886 5.44884 0" rot="1 0 0 0" scale="" transform="1 0 0 -0.937886 0 1 0 5.44884 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.469957 -0.362343 1" />
                            <Vertex pos="-0.0382138 -0.551156 1" />
                            <Vertex pos="-0.469957 -0.362343 -1" />
                            <Vertex pos="-0.0382138 -0.551156 -1" />
                            <Vertex pos="-0.0915767 0.551156 1" />
                            <Vertex pos="0.469958 0.551156 1" />
                            <Vertex pos="-0.0915767 0.551156 -1" />
                            <Vertex pos="0.469958 0.551156 -1" />
                        </Vertices>
                        <Face id="0" plane="-0.400685 -0.916216 0 -0.520289" album="" material="BM_GRID_BLANK4" texgens="0.92388 -0.382683 0 168.178 0 0 -1 128 0 0.235379 0.25" texRot="0" texScale="0.235379 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 1 -1" album="" material="BM_GRID_BLANK4" texgens="1 0 0 647.956 0 -1 0 -1465.45 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 -0 -1 -1" album="" material="BM_GRID_BLANK4" texgens="-1 0 0 -647.956 0 -1 0 -1465.45 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="-0.923881 0.382681 0 -0.295523" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.382685 0.923879 0 400.466 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.908144 -0.418659 0 -0.196043" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.382685 0.923879 0 400.466 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 1 0 -0.551156" album="" material="BM_GRID_BLANK4" texgens="-1 0 0 57.2499 0 0 1 126.129 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="11" owner="0" type="0" pos="-0.430904 5.34605 0" rot="1 0 0 0" scale="" transform="1 0 0 -0.430904 0 1 0 5.34605 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.545199 -0.44836 1" />
                            <Vertex pos="-0.121218 -0.653953 1" />
                            <Vertex pos="-0.545199 -0.44836 -1" />
                            <Vertex pos="-0.121218 -0.653953 -1" />
                            <Vertex pos="-0.0370272 0.653953 1" />
                            <Vertex pos="0.545199 0.653953 1" />
                            <Vertex pos="-0.0370272 0.653953 -1" />
                            <Vertex pos="0.545199 0.653953 -1" />
                        </Vertices>
                        <Face id="0" plane="-0.436319 -0.899792 0 -0.641312" album="" material="BM_GRID_BLANK4" texgens="0.92388 -0.382683 0 237.205 0 0 -1 128 0 0.235379 0.25" texRot="0" texScale="0.235379 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 1 -1" album="" material="BM_GRID_BLANK4" texgens="1 0 0 712.851 0 -1 0 -1452.29 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 -0 -1 -1" album="" material="BM_GRID_BLANK4" texgens="-1 0 0 -712.851 0 -1 0 -1452.29 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="-0.908144 0.418659 0 -0.307409" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.418662 0.908142 0 404.333 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.891005 -0.453994 0 -0.188885" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.418662 0.908142 0 404.333 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 1 0 -0.653953" album="" material="BM_GRID_BLANK4" texgens="-1 0 0 59.0928 0 0 1 126.001 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="12" owner="0" type="0" pos="0.0840921 5.23495 5.96046e-008" rot="1 0 0 0" scale="" transform="1 0 0 0.0840921 0 1 0 5.23495 0 0 1 5.96046e-008 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.636214 -0.54286 1" />
                            <Vertex pos="-0.22068 -0.765047 1" />
                            <Vertex pos="-0.636214 -0.54286 -1" />
                            <Vertex pos="-0.22068 -0.765047 -1" />
                            <Vertex pos="0.0302029 0.765047 1" />
                            <Vertex pos="0.636214 0.765047 1" />
                            <Vertex pos="0.0302029 0.765047 -1" />
                            <Vertex pos="0.636214 0.765047 -1" />
                        </Vertices>
                        <Face id="0" plane="-0.471528 -0.881851 0 -0.778714" album="" material="BM_GRID_BLANK4" texgens="0.852632 -0.522512 0 35.1841 0 0 -1 128 0 0.235375 0.25" texRot="0" texScale="0.235375 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 1 -1" album="" material="BM_GRID_BLANK4" texgens="1 0 0 778.77 0 -1 0 -1438.07 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 -0 -1 -1" album="" material="BM_GRID_BLANK4" texgens="-1 0 0 -778.77 0 -1 0 -1438.07 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="-0.891005 0.453993 0 -0.320415" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.453993 0.891006 0 408.722 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.872496 -0.488621 0 -0.181276" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.453993 0.891006 0 408.722 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 1 0 -0.765047" album="" material="BM_GRID_BLANK4" texgens="-1 0 0 60.3216 0 0 1 125.886 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="13" owner="0" type="0" pos="0.608498 5.11584 0" rot="1 0 0 0" scale="" transform="1 0 0 0.608498 0 1 0 5.11584 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.745086 -0.645937 1" />
                            <Vertex pos="-0.338537 -0.884156 1" />
                            <Vertex pos="-0.745086 -0.645937 -1" />
                            <Vertex pos="-0.338537 -0.884156 -1" />
                            <Vertex pos="0.111808 0.884156 1" />
                            <Vertex pos="0.745086 0.884156 1" />
                            <Vertex pos="0.111808 0.884156 -1" />
                            <Vertex pos="0.745086 0.884156 -1" />
                        </Vertices>
                        <Face id="0" plane="-0.505556 -0.862794 0 -0.933994" album="" material="BM_GRID_BLANK4" texgens="0.852632 -0.522512 0 104.433 0 0 -1 128 0 0.235375 0.25" texRot="0" texScale="0.235375 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 1 -1" album="" material="BM_GRID_BLANK4" texgens="1 0 0 845.894 0 -1 0 -1422.83 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 -0 -1 -1" album="" material="BM_GRID_BLANK4" texgens="-1 0 0 -845.894 0 -1 0 -1422.83 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="-0.872496 0.488621 0 -0.334466" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.488623 0.872495 0 413.683 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.85264 -0.522498 0 -0.17332" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.488623 0.872495 0 413.683 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 1 0 -0.884156" album="" material="BM_GRID_BLANK4" texgens="-1 0 0 60.8627 0 0 1 125.783 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="14" owner="0" type="0" pos="1.14402 4.98881 0" rot="1 0 0 0" scale="" transform="1 0 0 1.14402 0 1 0 4.98881 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.874063 -0.757125 1" />
                            <Vertex pos="-0.477234 -1.01119 1" />
                            <Vertex pos="-0.874063 -0.757125 -1" />
                            <Vertex pos="-0.477234 -1.01119 -1" />
                            <Vertex pos="0.20956 1.01119 1" />
                            <Vertex pos="0.874063 1.01119 1" />
                            <Vertex pos="0.20956 1.01119 -1" />
                            <Vertex pos="0.874063 1.01119 -1" />
                        </Vertices>
                        <Face id="0" plane="-0.539193 -0.842182 0 -1.10893" album="" material="BM_GRID_BLANK4" texgens="0.852632 -0.522512 0 175.535 0 0 -1 128 0 0.235375 0.25" texRot="0" texScale="0.235375 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 1 -1" album="" material="BM_GRID_BLANK4" texgens="1 0 0 914.442 0 -1 0 -1406.57 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 -0 -1 -1" album="" material="BM_GRID_BLANK4" texgens="-1 0 0 -914.442 0 -1 0 -1406.57 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="-0.85264 0.522498 0 -0.349665" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.5225 0.85264 0 419.273 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.831472 -0.555567 0 -0.164976" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.5225 0.85264 0 419.273 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 1 0 -1.01119" album="" material="BM_GRID_BLANK4" texgens="-1 0 0 60.6392 0 0 1 125.693 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="15" owner="0" type="0" pos="1.69263 4.85411 0" rot="1 0 0 0" scale="" transform="1 0 0 1.69263 0 1 0 4.85411 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.02584 -0.876484 1" />
                            <Vertex pos="-0.639247 -1.14589 1" />
                            <Vertex pos="-1.02584 -0.876484 -1" />
                            <Vertex pos="-0.639247 -1.14589 -1" />
                            <Vertex pos="0.325453 1.14589 1" />
                            <Vertex pos="1.02584 1.14589 1" />
                            <Vertex pos="0.325453 1.14589 -1" />
                            <Vertex pos="1.02584 1.14589 -1" />
                        </Vertices>
                        <Face id="0" plane="-0.571735 -0.820438 0 -1.30561" album="" material="BM_GRID_BLANK4" texgens="0.852632 -0.522512 0 248.697 0 0 -1 128 0 0.235375 0.25" texRot="0" texScale="0.235375 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 1 -1" album="" material="BM_GRID_BLANK4" texgens="1 0 0 984.663 0 -1 0 -1389.33 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 -0 -1 -1" album="" material="BM_GRID_BLANK4" texgens="-1 0 0 -984.663 0 -1 0 -1389.33 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="-0.831472 0.555567 0 -0.366014" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.55557 0.83147 0 425.558 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.809015 -0.587789 0 -0.156381" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.55557 0.83147 0 425.558 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 1 0 -1.14589" album="" material="BM_GRID_BLANK4" texgens="-1 0 0 59.5617 0 0 1 125.617 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="16" owner="0" type="0" pos="2.25671 4.71189 5.96046e-008" rot="1 0 0 0" scale="" transform="1 0 0 2.25671 0 1 0 4.71189 0 0 1 5.96046e-008 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.20332 -1.0037 1" />
                            <Vertex pos="-0.827613 -1.28811 1" />
                            <Vertex pos="-1.20332 -1.0037 -1" />
                            <Vertex pos="-0.827613 -1.28811 -1" />
                            <Vertex pos="0.461772 1.28811 1" />
                            <Vertex pos="1.20332 1.28811 1" />
                            <Vertex pos="0.461772 1.28811 -1" />
                            <Vertex pos="1.20332 1.28811 -1" />
                        </Vertices>
                        <Face id="0" plane="-0.603558 -0.797319 0 -1.52655" album="" material="BM_GRID_BLANK4" texgens="0.760402 -0.649453 0 35.7757 0 0 -1 128 0 0.235381 0.25" texRot="0" texScale="0.235381 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 1 -1" album="" material="BM_GRID_BLANK4" texgens="1 0 0 1056.86 0 -1 0 -1371.12 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 -0 -1 -1" album="" material="BM_GRID_BLANK4" texgens="-1 0 0 -1056.86 0 -1 0 -1371.12 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="-0.809018 0.587784 0 -0.383548" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.587786 0.809017 0 432.618 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.785316 -0.619095 0 -0.147525" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.587786 0.809017 0 432.618 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 1 0 -1.28811" album="" material="BM_GRID_BLANK4" texgens="-1 0 0 57.5293 0 0 1 125.556 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="17" owner="0" type="0" pos="2.83903 4.56243 0" rot="1 0 0 0" scale="" transform="1 0 0 2.83903 0 1 0 4.56243 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.40994 -1.13865 1" />
                            <Vertex pos="-1.04569 -1.43757 1" />
                            <Vertex pos="-1.40994 -1.13865 -1" />
                            <Vertex pos="-1.04569 -1.43757 -1" />
                            <Vertex pos="0.620998 1.43757 1" />
                            <Vertex pos="1.40994 1.43757 1" />
                            <Vertex pos="0.620998 1.43757 -1" />
                            <Vertex pos="1.40994 1.43757 -1" />
                        </Vertices>
                        <Face id="0" plane="-0.634384 -0.773018 0 -1.77464" album="" material="BM_GRID_BLANK4" texgens="0.760402 -0.649453 0 109.171 0 0 -1 128 0 0.235381 0.25" texRot="0" texScale="0.235381 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 1 -1" album="" material="BM_GRID_BLANK4" texgens="1 0 0 1131.4 0 -1 0 -1351.99 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 -0 -1 -1" album="" material="BM_GRID_BLANK4" texgens="-1 0 0 -1131.4 0 -1 0 -1351.99 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="-0.785316 0.619095 0 -0.402314" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.619096 0.785316 0 440.547 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.760404 -0.649451 0 -0.138489" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.619096 0.785316 0 440.547 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 1 0 -1.43757" album="" material="BM_GRID_BLANK4" texgens="-1 0 0 54.4289 0 0 1 125.511 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="18" owner="0" type="0" pos="3.44305 4.40592 0" rot="1 0 0 0" scale="" transform="1 0 0 3.44305 0 1 0 4.40592 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.6497 -1.28106 1" />
                            <Vertex pos="-1.29745 -1.59408 1" />
                            <Vertex pos="-1.6497 -1.28106 -1" />
                            <Vertex pos="-1.29745 -1.59408 -1" />
                            <Vertex pos="0.80592 1.59408 1" />
                            <Vertex pos="1.6497 1.59408 1" />
                            <Vertex pos="0.80592 1.59408 -1" />
                            <Vertex pos="1.6497 1.59408 -1" />
                        </Vertices>
                        <Face id="0" plane="-0.664255 -0.747506 0 -2.05342" album="" material="BM_GRID_BLANK4" texgens="0.760402 -0.649453 0 185.43 0 0 -1 128 0 0.235381 0.25" texRot="0" texScale="0.235381 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 1 -1" album="" material="BM_GRID_BLANK4" texgens="1 0 0 1208.72 0 -1 0 -1331.96 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 -0 -1 -1" album="" material="BM_GRID_BLANK4" texgens="-1 0 0 -1208.72 0 -1 0 -1331.96 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="-0.760404 0.649451 0 -0.422455" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.64945 0.760405 0 449.457 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.734319 -0.678805 0 -0.129334" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.64945 0.760405 0 449.457 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="5.65119e-007 1 0 -1.59409" album="" material="BM_GRID_BLANK4" texgens="-1 0 0 50.1284 0 0 1 125.48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="19" owner="0" type="0" pos="4.07282 4.24262 0" rot="1 0 0 0" scale="" transform="1 0 0 4.07282 0 1 0 4.24262 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.92721 -1.4308 1" />
                            <Vertex pos="-1.58755 -1.75738 1" />
                            <Vertex pos="-1.92721 -1.4308 -1" />
                            <Vertex pos="-1.58755 -1.75738 -1" />
                            <Vertex pos="1.01993 1.75737 1" />
                            <Vertex pos="1.92721 1.75737 1" />
                            <Vertex pos="1.01993 1.75737 -1" />
                            <Vertex pos="1.92721 1.75737 -1" />
                        </Vertices>
                        <Face id="0" plane="-0.69309 -0.720851 0 -2.36712" album="" material="BM_GRID_BLANK4" texgens="0.760402 -0.649453 0 264.951 0 0 -1 128 0 0.235381 0.25" texRot="0" texScale="0.235381 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 1 -1" album="" material="BM_GRID_BLANK4" texgens="1 0 0 1289.33 0 -1 0 -1311.06 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 -0 -1 -1" album="" material="BM_GRID_BLANK4" texgens="-1 0 0 -1289.33 0 -1 0 -1311.06 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="-0.734319 0.678805 0 -0.443958" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.678804 0.734319 0 459.484 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.707105 -0.707109 0 -0.120088" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.678804 0.734319 0 459.484 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="5.25567e-007 1 0 -1.75738" album="" material="BM_GRID_BLANK4" texgens="-1 0 0 44.4719 0 0 1 125.465 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="20" owner="0" type="0" pos="4.85405 1.69266 5.96046e-008" rot="1 0 0 0" scale="" transform="1 0 0 4.85405 0 1 0 1.69266 0 0 1 5.96046e-008 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.14589 -0.639253 1" />
                            <Vertex pos="-0.876453 -1.02582 1" />
                            <Vertex pos="-1.14589 -0.639253 -1" />
                            <Vertex pos="-0.876453 -1.02582 -1" />
                            <Vertex pos="1.14589 1.02582 1" />
                            <Vertex pos="1.14589 0.325481 1" />
                            <Vertex pos="1.14589 1.02582 -1" />
                            <Vertex pos="1.14589 0.325481 -1" />
                        </Vertices>
                        <Face id="0" plane="-0.820383 -0.571814 0 -1.3056" album="" material="BM_GRID_BLANK4" texgens="0.522496 -0.852642 0 7.29579 0 0 -1 128 0 0.235381 0.25" texRot="0" texScale="0.235381 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 1 -1" album="" material="BM_GRID_BLANK4" texgens="1 0 0 1389.32 0 -1 0 -984.66 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 -0 -1 -1" album="" material="BM_GRID_BLANK4" texgens="-1 0 0 -1389.32 0 -1 0 -984.66 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="-0.587783 0.809018 0 -0.156368" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.809018 0.587784 0 425.689 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.555573 -0.831468 0 -0.365999" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.809018 0.587784 0 425.689 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="1 -0 0 -1.14589" album="" material="BM_GRID_BLANK4" texgens="0 -1 0 57.822 0 0 1 125.618 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="21" owner="0" type="0" pos="4.98877 1.14404 0" rot="1 0 0 0" scale="" transform="1 0 0 4.98877 0 1 0 1.14404 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.01117 -0.477203 1" />
                            <Vertex pos="-0.757109 -0.874093 1" />
                            <Vertex pos="-1.01117 -0.477203 -1" />
                            <Vertex pos="-0.757109 -0.874093 -1" />
                            <Vertex pos="1.01117 0.874093 1" />
                            <Vertex pos="1.01117 0.209515 1" />
                            <Vertex pos="1.01117 0.874093 -1" />
                            <Vertex pos="1.01117 0.209515 -1" />
                        </Vertices>
                        <Face id="0" plane="-0.84222 -0.539134 0 -1.10891" album="" material="BM_GRID_BLANK4" texgens="0.522496 -0.852642 0 80.4586 0 0 -1 128 0 0.235381 0.25" texRot="0" texScale="0.235381 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 1 -1" album="" material="BM_GRID_BLANK4" texgens="1 0 0 1406.57 0 -1 0 -914.438 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 -0 -1 -1" album="" material="BM_GRID_BLANK4" texgens="-1 0 0 -1406.57 0 -1 0 -914.438 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="-0.555573 0.831468 0 -0.165" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.83147 0.55557 0 419.388 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.5225 -0.852639 0 -0.349697" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.83147 0.55557 0 419.388 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="1 7.17504e-007 0 -1.01117" album="" material="BM_GRID_BLANK4" texgens="0 -1 0 58.5358 0 0 1 125.693 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="22" owner="0" type="0" pos="5.1158 0.60849 0" rot="1 0 0 0" scale="" transform="1 0 0 5.1158 0 1 0 0.60849 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.884141 -0.338539 1" />
                            <Vertex pos="-0.64586 -0.745069 1" />
                            <Vertex pos="-0.884141 -0.338539 -1" />
                            <Vertex pos="-0.64586 -0.745069 -1" />
                            <Vertex pos="0.884141 0.745069 1" />
                            <Vertex pos="0.884141 0.111763 1" />
                            <Vertex pos="0.884141 0.745069 -1" />
                            <Vertex pos="0.884141 0.111763 -1" />
                        </Vertices>
                        <Face id="0" plane="-0.862725 -0.505673 0 -0.933961" album="" material="BM_GRID_BLANK4" texgens="0.522496 -0.852642 0 151.561 0 0 -1 128 0 0.235381 0.25" texRot="0" texScale="0.235381 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 1 -1" album="" material="BM_GRID_BLANK4" texgens="1 0 0 1422.83 0 -1 0 -845.887 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 -0 -1 -1" album="" material="BM_GRID_BLANK4" texgens="-1 0 0 -1422.83 0 -1 0 -845.887 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="-0.5225 0.852639 0 -0.173312" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.852642 0.522496 0 413.784 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.488617 -0.872499 0 -0.334493" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.852642 0.522496 0 413.784 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="1 -0 0 -0.884141" album="" material="BM_GRID_BLANK4" texgens="0 -1 0 58.408 0 0 1 125.782 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="23" owner="0" type="0" pos="5.23494 0.0840453 0" rot="1 0 0 0" scale="" transform="1 0 0 5.23494 0 1 0 0.0840453 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.765 -0.220625 1" />
                            <Vertex pos="-0.542875 -0.636208 1" />
                            <Vertex pos="-0.765 -0.220625 -1" />
                            <Vertex pos="-0.542875 -0.636208 -1" />
                            <Vertex pos="0.765 0.636208 1" />
                            <Vertex pos="0.765 0.0301893 1" />
                            <Vertex pos="0.765 0.636208 -1" />
                            <Vertex pos="0.765 0.0301893 -1" />
                        </Vertices>
                        <Face id="0" plane="-0.881929 -0.471383 0 -0.778674" album="" material="BM_GRID_BLANK4" texgens="0.522496 -0.852642 0 220.817 0 0 -1 128 0 0.235381 0.25" texRot="0" texScale="0.235381 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 1 -1" album="" material="BM_GRID_BLANK4" texgens="1 0 0 1438.08 0 -1 0 -778.758 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 -0 -1 -1" album="" material="BM_GRID_BLANK4" texgens="-1 0 0 -1438.08 0 -1 0 -778.758 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="-0.488617 0.872498 0 -0.181298" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.872498 0.488617 0 408.809 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.453991 -0.891006 0 -0.320405" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.872498 0.488617 0 408.809 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="1 -0 0 -0.765" album="" material="BM_GRID_BLANK4" texgens="0 -1 0 57.5297 0 0 1 125.886 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="24" owner="0" type="0" pos="5.346 -0.430951 5.96046e-008" rot="1 0 0 0" scale="" transform="1 0 0 5.346 0 1 0 -0.430951 0 0 1 5.96046e-008 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.653938 -0.121211 1" />
                            <Vertex pos="-0.448344 -0.545186 1" />
                            <Vertex pos="-0.653938 -0.121211 -1" />
                            <Vertex pos="-0.448344 -0.545186 -1" />
                            <Vertex pos="0.653938 0.545186 1" />
                            <Vertex pos="0.653938 -0.0370268 1" />
                            <Vertex pos="0.653938 0.545186 -1" />
                            <Vertex pos="0.653938 -0.0370268 -1" />
                        </Vertices>
                        <Face id="0" plane="-0.899789 -0.436326 0 -0.641294" album="" material="BM_GRID_BLANK4" texgens="0.382682 -0.92388 0 18.7972 0 0 -1 128 0 0.235377 0.25" texRot="0" texScale="0.235377 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 1 -1" album="" material="BM_GRID_BLANK4" texgens="1 0 0 1452.29 0 -1 0 -712.838 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 -0 -1 -1" album="" material="BM_GRID_BLANK4" texgens="-1 0 0 -1452.29 0 -1 0 -712.838 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="-0.453991 0.891006 0 -0.188882" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.891009 0.453986 0 404.406 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.41866 -0.908143 0 -0.307404" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.891009 0.453986 0 404.406 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="1 8.19008e-007 0 -0.653938" album="" material="BM_GRID_BLANK4" texgens="0 -1 0 55.9816 0 0 1 126.002 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="25" owner="0" type="0" pos="5.4488 -0.937902 -5.96046e-008" rot="1 0 0 0" scale="" transform="1 0 0 5.4488 0 1 0 -0.937902 0 0 1 -5.96046e-008 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.551141 -0.038236 1" />
                            <Vertex pos="-0.362266 -0.469923 1" />
                            <Vertex pos="-0.551141 -0.038236 -1" />
                            <Vertex pos="-0.362266 -0.469923 -1" />
                            <Vertex pos="0.551141 0.469923 1" />
                            <Vertex pos="0.55114 -0.0915829 1" />
                            <Vertex pos="0.551141 0.469923 -1" />
                            <Vertex pos="0.55114 -0.0915829 -1" />
                        </Vertices>
                        <Face id="0" plane="-0.916148 -0.400839 0 -0.520253" album="" material="BM_GRID_BLANK4" texgens="0.382682 -0.92388 0 87.8202 0 0 -1 128 0 0.235377 0.25" texRot="0" texScale="0.235377 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 1 -1" album="" material="BM_GRID_BLANK4" texgens="1 0 0 1465.45 0 -1 0 -647.948 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -1" album="" material="BM_GRID_BLANK4" texgens="-1 0 0 -1465.45 0 -1 0 -647.948 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="-0.41866 0.908143 0 -0.196017" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.908145 0.418656 0 400.528 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.382679 -0.923881 0 -0.295522" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.908145 0.418656 0 400.528 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="1 -8.49211e-007 0 -0.55114" album="" material="BM_GRID_BLANK4" texgens="0 -1 0 53.8383 0 0 1 126.13 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="26" owner="0" type="0" pos="5.54323 -1.43807 0" rot="1 0 0 0" scale="" transform="1 0 0 5.54323 0 1 0 -1.43807 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.456703 0.0302442 1" />
                            <Vertex pos="-0.284984 -0.408584 1" />
                            <Vertex pos="-0.456703 0.0302442 -1" />
                            <Vertex pos="-0.284984 -0.408584 -1" />
                            <Vertex pos="0.456703 0.408584 1" />
                            <Vertex pos="0.456703 -0.134963 1" />
                            <Vertex pos="0.456703 0.408584 -1" />
                            <Vertex pos="0.456703 -0.134963 -1" />
                        </Vertices>
                        <Face id="0" plane="-0.93124 -0.364407 0 -0.414279" album="" material="BM_GRID_BLANK4" texgens="0.382682 -0.92388 0 155.556 0 0 -1 128 0 0.235377 0.25" texRot="0" texScale="0.235377 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 1 -1" album="" material="BM_GRID_BLANK4" texgens="1 0 0 1477.54 0 -1 0 -583.927 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 -0 -1 -1" album="" material="BM_GRID_BLANK4" texgens="-1 0 0 -1477.54 0 -1 0 -583.927 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="-0.382679 0.923881 0 -0.202713" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.923881 0.38268 0 397.132 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.346116 -0.938192 0 -0.284693" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.923881 0.38268 0 397.132 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="1 -0 0 -0.456703" album="" material="BM_GRID_BLANK4" texgens="0 -1 0 51.1691 0 0 1 126.269 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="27" owner="0" type="0" pos="5.62909 -1.93244 5.96046e-008" rot="1 0 0 0" scale="" transform="1 0 0 5.62909 0 1 0 -1.93244 0 0 1 5.96046e-008 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.370844 0.0857861 1" />
                            <Vertex pos="-0.216438 -0.359408 1" />
                            <Vertex pos="-0.370844 0.0857861 -1" />
                            <Vertex pos="-0.216438 -0.359408 -1" />
                            <Vertex pos="0.370843 0.359408 1" />
                            <Vertex pos="0.370843 -0.168586 1" />
                            <Vertex pos="0.370843 0.359408 -1" />
                            <Vertex pos="0.370843 -0.168586 -1" />
                        </Vertices>
                        <Face id="0" plane="-0.944789 -0.32768 0 -0.322259" album="" material="BM_GRID_BLANK4" texgens="0.382682 -0.92388 0 222.116 0 0 -1 128 0 0.235377 0.25" texRot="0" texScale="0.235377 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 1 -1" album="" material="BM_GRID_BLANK4" texgens="1 0 0 1488.53 0 -1 0 -520.648 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 -0 -1 -1" album="" material="BM_GRID_BLANK4" texgens="-1 0 0 -1488.53 0 -1 0 -520.648 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="-0.346116 0.938192 0 -0.208839" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.938193 0.346113 0 394.183 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.309021 -0.951055 0 -0.274933" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.938193 0.346113 0 394.183 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="1 -0 0 -0.370843" album="" material="BM_GRID_BLANK4" texgens="0 -1 0 48.0325 0 0 1 126.42 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="28" owner="0" type="0" pos="5.7063 -2.42189 5.96046e-008" rot="1 0 0 0" scale="" transform="1 0 0 5.7063 0 1 0 -2.42189 0 0 1 5.96046e-008 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.293641 0.130042 1" />
                            <Vertex pos="-0.156859 -0.320864 1" />
                            <Vertex pos="-0.293641 0.130042 -1" />
                            <Vertex pos="-0.156859 -0.320864 -1" />
                            <Vertex pos="0.293641 0.320864 1" />
                            <Vertex pos="0.293641 -0.193811 1" />
                            <Vertex pos="0.293641 0.320864 -1" />
                            <Vertex pos="0.293641 -0.193811 -1" />
                        </Vertices>
                        <Face id="0" plane="-0.95694 -0.290285 0 -0.243247" album="" material="BM_GRID_BLANK4" texgens="0.233453 -0.972368 0 26.511 0 0 -1 128 0 0.235378 0.25" texRot="0" texScale="0.235378 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 1 -1" album="" material="BM_GRID_BLANK4" texgens="1 0 0 1498.41 0 -1 0 -457.999 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 -0 -1 -1" album="" material="BM_GRID_BLANK4" texgens="-1 0 0 -1498.41 0 -1 0 -457.999 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="-0.309021 0.951055 0 -0.214418" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.951058 0.309013 0 391.651 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.271438 -0.962456 0 -0.26624" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.951058 0.309013 0 391.651 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="1 -0 0 -0.293641" album="" material="BM_GRID_BLANK4" texgens="0 -1 0 44.4888 0 0 1 126.58 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="29" owner="0" type="0" pos="5.77469 -2.90719 0" rot="1 0 0 0" scale="" transform="1 0 0 5.77469 0 1 0 -2.90719 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.225249 0.164443 1" />
                            <Vertex pos="-0.106249 -0.291495 1" />
                            <Vertex pos="-0.225249 0.164443 -1" />
                            <Vertex pos="-0.106249 -0.291495 -1" />
                            <Vertex pos="0.22525 0.291496 1" />
                            <Vertex pos="0.22525 -0.211917 1" />
                            <Vertex pos="0.22525 0.291496 -1" />
                            <Vertex pos="0.22525 -0.211917 -1" />
                        </Vertices>
                        <Face id="0" plane="-0.967586 -0.25254 0 -0.17642" album="" material="BM_GRID_BLANK4" texgens="0.233453 -0.972368 0 92.8367 0 0 -1 128 0 0.235378 0.25" texRot="0" texScale="0.235378 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 1 -1" album="" material="BM_GRID_BLANK4" texgens="1 0 0 1507.17 0 -1 0 -395.879 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 -0 -1 -1" album="" material="BM_GRID_BLANK4" texgens="-1 0 0 -1507.17 0 -1 0 -395.879 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="-0.271438 0.962456 0 -0.21941" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.962456 0.271437 0 389.509 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.233423 -0.972375 0 -0.258642" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.962456 0.271437 0 389.509 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="1 -0 0 -0.22525" album="" material="BM_GRID_BLANK4" texgens="0 -1 0 40.5932 0 0 1 126.747 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="30" owner="0" type="0" pos="5.83419 -3.38904 0" rot="1 0 0 0" scale="" transform="1 0 0 5.83419 0 1 0 -3.38904 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.16575 0.190351 1" />
                            <Vertex pos="-0.0648441 -0.269929 1" />
                            <Vertex pos="-0.16575 0.190351 -1" />
                            <Vertex pos="-0.0648441 -0.269929 -1" />
                            <Vertex pos="0.16575 0.269929 1" />
                            <Vertex pos="0.16575 -0.224054 1" />
                            <Vertex pos="0.16575 0.269929 -1" />
                            <Vertex pos="0.16575 -0.224054 -1" />
                        </Vertices>
                        <Face id="0" plane="-0.976803 -0.214142 0 -0.121143" album="" material="BM_GRID_BLANK4" texgens="0.233453 -0.972368 0 158.423 0 0 -1 128 0 0.235378 0.25" texRot="0" texScale="0.235378 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 1 -1" album="" material="BM_GRID_BLANK4" texgens="1 0 0 1514.78 0 -1 0 -334.203 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 -0 -1 -1" album="" material="BM_GRID_BLANK4" texgens="-1 0 0 -1514.78 0 -1 0 -334.203 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="-0.233423 0.972375 0 -0.223782" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.972371 0.233441 0 387.736 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.195119 -0.98078 0 -0.252089" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.972371 0.233441 0 387.736 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="1 -0 0 -0.16575" album="" material="BM_GRID_BLANK4" texgens="0 -1 0 36.3964 0 0 1 126.922 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="31" owner="0" type="0" pos="5.88464 -3.86797 0" rot="1 0 0 0" scale="" transform="1 0 0 5.88464 0 1 0 -3.86797 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.115296 0.209001 1" />
                            <Vertex pos="-0.0323901 -0.254875 1" />
                            <Vertex pos="-0.115296 0.209001 -1" />
                            <Vertex pos="-0.0323901 -0.254875 -1" />
                            <Vertex pos="0.115296 0.254875 1" />
                            <Vertex pos="0.115296 -0.231469 1" />
                            <Vertex pos="0.115296 0.254875 -1" />
                            <Vertex pos="0.115296 -0.231469 -1" />
                        </Vertices>
                        <Face id="0" plane="-0.984401 -0.175937 0 -0.0767269" album="" material="BM_GRID_BLANK4" texgens="0.233453 -0.972368 0 223.336 0 0 -1 128 0 0.235378 0.25" texRot="0" texScale="0.235378 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 1 -1" album="" material="BM_GRID_BLANK4" texgens="1 0 0 1521.24 0 -1 0 -272.9 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 -0 -1 -1" album="" material="BM_GRID_BLANK4" texgens="-1 0 0 -1521.24 0 -1 0 -272.9 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="-0.195118 0.98078 0 -0.22748" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.980786 0.195086 0 386.313 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.156531 -0.987673 0 -0.246663" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.980786 0.195086 0 386.313 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="1 -0 0 -0.115296" album="" material="BM_GRID_BLANK4" texgens="0 -1 0 31.9474 0 0 1 127.106 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="32" owner="0" type="0" pos="5.92609 -4.34452 0" rot="1 0 0 0" scale="" transform="1 0 0 5.92609 0 1 0 -4.34452 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.073844 0.221672 1" />
                            <Vertex pos="-0.0093441 -0.245078 1" />
                            <Vertex pos="-0.073844 0.221672 -1" />
                            <Vertex pos="-0.0093441 -0.245078 -1" />
                            <Vertex pos="0.073844 0.245078 1" />
                            <Vertex pos="0.073844 -0.235234 1" />
                            <Vertex pos="0.073844 0.245078 -1" />
                            <Vertex pos="0.073844 -0.235234 -1" />
                        </Vertices>
                        <Face id="0" plane="-0.990586 -0.136888 0 -0.0428045" album="" material="BM_GRID_BLANK4" texgens="0.0784391 -0.996919 0 30.8321 0 0 -1 128 0 0.235371 0.25" texRot="0" texScale="0.235371 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 1 -1" album="" material="BM_GRID_BLANK4" texgens="1 0 0 1526.55 0 -1 0 -211.902 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 -0 -1 -1" album="" material="BM_GRID_BLANK4" texgens="-1 0 0 -1526.55 0 -1 0 -211.902 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="-0.156529 0.987673 0 -0.230498" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.987689 0.15643 0 385.225 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.117518 -0.993071 0 -0.242282" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.987689 0.15643 0 385.225 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="1 -0 0 -0.073844" album="" material="BM_GRID_BLANK4" texgens="0 -1 0 27.2945 0 0 1 127.293 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="33" owner="0" type="0" pos="5.95834 -4.81916 0" rot="1 0 0 0" scale="" transform="1 0 0 5.95834 0 1 0 -4.81916 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.0415931 0.229562 1" />
                            <Vertex pos="0.0046258 -0.239406 1" />
                            <Vertex pos="-0.0415931 0.229562 -1" />
                            <Vertex pos="0.0046258 -0.239406 -1" />
                            <Vertex pos="0.0415931 0.239406 1" />
                            <Vertex pos="0.0415931 -0.236469 1" />
                            <Vertex pos="0.0415931 0.239406 -1" />
                            <Vertex pos="0.0415931 -0.236469 -1" />
                        </Vertices>
                        <Face id="0" plane="-0.995179 -0.0980792 0 -0.0188773" album="" material="BM_GRID_BLANK4" texgens="0.0784391 -0.996919 0 95.5059 0 0 -1 128 0 0.235371 0.25" texRot="0" texScale="0.235371 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 1 -1" album="" material="BM_GRID_BLANK4" texgens="1 0 0 1530.67 0 -1 0 -151.148 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 -0 -1 -1" album="" material="BM_GRID_BLANK4" texgens="-1 0 0 -1530.67 0 -1 0 -151.148 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="-0.117509 0.993072 0 -0.232859" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.993069 0.117533 0 384.457 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.0792076 -0.996858 0 -0.23902" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.993069 0.117533 0 384.457 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="1 -0 0 -0.0415931" album="" material="BM_GRID_BLANK4" texgens="0 -1 0 22.483 0 0 1 127.486 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="34" owner="0" type="0" pos="5.98145 -5.29228 0" rot="1 0 0 0" scale="" transform="1 0 0 5.98145 0 1 0 -5.29228 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.0184841 0.233719 1" />
                            <Vertex pos="0.00929689 -0.236657 1" />
                            <Vertex pos="-0.0184841 0.233719 -1" />
                            <Vertex pos="0.00929689 -0.236657 -1" />
                            <Vertex pos="0.0184846 0.236657 1" />
                            <Vertex pos="0.0184846 -0.236282 1" />
                            <Vertex pos="0.0184846 0.236657 -1" />
                            <Vertex pos="0.0184846 -0.236282 -1" />
                        </Vertices>
                        <Face id="0" plane="-0.99826 -0.0589585 0 -0.00467221" album="" material="BM_GRID_BLANK4" texgens="0.0784391 -0.996919 0 159.878 0 0 -1 128 0 0.235371 0.25" texRot="0" texScale="0.235371 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 1 -1" album="" material="BM_GRID_BLANK4" texgens="1 0 0 1533.63 0 -1 0 -90.5879 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 -0 -1 -1" album="" material="BM_GRID_BLANK4" texgens="-1 0 0 -1533.63 0 -1 0 -90.5879 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="-0.0792045 0.996858 0 -0.234449" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.996918 0.0784543 0 384.003 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.0407591 -0.999169 0 -0.236839" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.996918 0.0784543 0 384.003 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="1 -0 0 -0.0184846" album="" material="BM_GRID_BLANK4" texgens="0 -1 0 17.556 0 0 1 127.681 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="35" owner="0" type="0" pos="5.99536 -5.76428 0" rot="1 0 0 0" scale="" transform="1 0 0 5.99536 0 1 0 -5.76428 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.00460958 0.235343 1" />
                            <Vertex pos="0.00460911 -0.235718 1" />
                            <Vertex pos="-0.00460958 0.235343 -1" />
                            <Vertex pos="0.00460911 -0.235718 -1" />
                            <Vertex pos="0.00457811 0.235718 1" />
                            <Vertex pos="0.00457811 0.235718 -1" />
                        </Vertices>
                        <Face id="0" plane="-0.999809 -0.0195663 0 -3.90504e-006" album="" material="BM_GRID_BLANK4" texgens="0.0784391 -0.996919 0 224.001 0 0 -1 128 0 0.235371 0.25" texRot="0" texScale="0.235371 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 1 -1" album="" material="BM_GRID_BLANK4" texgens="1 0 0 1535.41 0 -1 0 -30.1719 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -1" album="" material="BM_GRID_BLANK4" texgens="-1 0 0 -1535.41 0 -1 0 -30.1719 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 2 3" />
                        </Face>
                        <Face id="3" plane="-0.0407591 0.999169 0 -0.235335" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.999229 0.0392553 0 383.854 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 4 0 2" />
                        </Face>
                        <Face id="4" plane="1 6.57448e-005 -0 -0.00459361" album="" material="BM_GRID_BLANK4" texgens="0 -1 0 12.56 0 0 1 127.876 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="36" owner="0" type="0" pos="4.24265 4.07279 0" rot="1 0 0 0" scale="" transform="1 0 0 4.24265 0 1 0 4.07279 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.75738 -1.58754 1" />
                            <Vertex pos="-1.75738 -1.58754 -1" />
                            <Vertex pos="-1.43081 -1.9272 1" />
                            <Vertex pos="-1.43081 -1.9272 -1" />
                            <Vertex pos="1.75738 1.92721 1" />
                            <Vertex pos="1.75738 1.92721 -1" />
                            <Vertex pos="1.75729 1.01983 1" />
                            <Vertex pos="1.75729 1.01983 -1" />
                        </Vertices>
                        <Face id="0" plane="-0.720852 -0.693089 0 -2.36712" album="" material="BM_GRID_BLANK4" texgens="0.649447 -0.760407 0 -8.95293 0 0 -1 128 0 0.235375 0.25" texRot="0" texScale="0.235375 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="-0.707105 0.707109 0 -0.120088" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.707109 0.707104 0 459.687 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 -0 1 -1" album="" material="BM_GRID_BLANK4" texgens="1 0 0 1311.06 0 -1 0 -1289.32 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 0 -1 -1" album="" material="BM_GRID_BLANK4" texgens="-1 0 0 -1311.06 0 -1 0 -1289.32 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="0.678799 -0.734324 0 -0.443962" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.707109 0.707104 0 459.687 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 -0.000103526 0 -1.75719" album="" material="BM_GRID_BLANK4" texgens="0 -1 0 44.2746 0 0 1 125.465 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="37" owner="0" type="0" pos="4.40589 3.44298 -2.98023e-008" rot="1 0 0 0" scale="" transform="1 0 0 4.40589 0 1 0 3.44298 0 0 1 -2.98023e-008 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.59405 -1.29739 1" />
                            <Vertex pos="-1.28102 -1.64965 1" />
                            <Vertex pos="-1.59405 -1.29739 -1" />
                            <Vertex pos="-1.28102 -1.64965 -1" />
                            <Vertex pos="1.59405 1.64965 1" />
                            <Vertex pos="1.59405 0.805895 1" />
                            <Vertex pos="1.59405 1.64965 -1" />
                            <Vertex pos="1.59405 0.805895 -1" />
                        </Vertices>
                        <Face id="0" plane="-0.747509 -0.664252 0 -2.05336" album="" material="BM_GRID_BLANK4" texgens="0.649447 -0.760407 0 70.5707 0 0 -1 128 0 0.235375 0.25" texRot="0" texScale="0.235375 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1.64321e-007 -1.92395e-007 1 -1" album="" material="BM_GRID_BLANK4" texgens="1 0 0 1331.96 0 -1 0 -1208.7 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -1" album="" material="BM_GRID_BLANK4" texgens="-1 0 0 -1331.96 0 -1 0 -1208.7 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="-0.678799 0.734324 0 -0.129336" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.734324 0.678799 0 449.639 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.649448 -0.760406 0 -0.422443" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.734324 0.678799 0 449.639 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="1 -5.6514e-007 0 -1.59405" album="" material="BM_GRID_BLANK4" texgens="0 -1 0 49.5386 0 0 1 125.48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="38" owner="0" type="0" pos="4.5624 2.83898 0" rot="1 0 0 0" scale="" transform="1 0 0 4.5624 0 1 0 2.83898 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.43754 -1.04565 1" />
                            <Vertex pos="-1.13862 -1.4099 1" />
                            <Vertex pos="-1.43754 -1.04565 -1" />
                            <Vertex pos="-1.13862 -1.4099 -1" />
                            <Vertex pos="1.43754 1.4099 1" />
                            <Vertex pos="1.43754 0.620958 1" />
                            <Vertex pos="1.43754 1.4099 -1" />
                            <Vertex pos="1.43754 0.620958 -1" />
                        </Vertices>
                        <Face id="0" plane="-0.773028 -0.634372 0 -1.77458" album="" material="BM_GRID_BLANK4" texgens="0.649447 -0.760407 0 146.831 0 0 -1 128 0 0.235375 0.25" texRot="0" texScale="0.235375 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 1 -1" album="" material="BM_GRID_BLANK4" texgens="1 0 0 1351.99 0 -1 0 -1131.39 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 -0 -1 -1" album="" material="BM_GRID_BLANK4" texgens="-1 0 0 -1351.99 0 -1 0 -1131.39 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="-0.649448 0.760406 0 -0.138489" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.760409 0.649444 0 440.711 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.619089 -0.785321 0 -0.402312" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.760409 0.649444 0 440.711 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="1 -0 0 -1.43754" album="" material="BM_GRID_BLANK4" texgens="0 -1 0 53.4487 0 0 1 125.511 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="39" owner="0" type="0" pos="4.71186 2.25667 0" rot="1 0 0 0" scale="" transform="1 0 0 4.71186 0 1 0 2.25667 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.0037 -1.20327 1" />
                            <Vertex pos="-1.0037 -1.20327 -1" />
                            <Vertex pos="-1.28808 -0.827589 1" />
                            <Vertex pos="-1.28808 -0.827589 -1" />
                            <Vertex pos="1.28808 0.461805 1" />
                            <Vertex pos="1.28808 0.461805 -1" />
                            <Vertex pos="1.28808 1.20327 1" />
                            <Vertex pos="1.28808 1.20327 -1" />
                        </Vertices>
                        <Face id="0" plane="-0.797326 -0.603548 -0 -1.52651" album="" material="BM_GRID_BLANK4" texgens="0.649447 -0.760407 0 220.227 0 0 -1 128 0 0.235375 0.25" texRot="0" texScale="0.235375 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0.587784 -0.809018 0 -0.383504" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.78532 0.61909 0 432.765 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 -0 1 -1" album="" material="BM_GRID_BLANK4" texgens="1 0 0 1371.12 0 -1 0 -1056.85 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="3" plane="0 0 -1 -1" album="" material="BM_GRID_BLANK4" texgens="-1 0 0 -1371.12 0 -1 0 -1056.85 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="4" plane="-0.61909 0.78532 0 -0.147514" album="" material="BM_GRID_BLANK4" texgens="0 0 -1 32 0.78532 0.61909 0 432.765 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="5" plane="1 0 0 -1.28808" album="" material="BM_GRID_BLANK4" texgens="0 -1 0 78.7495 0 0 1 514.235 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                </Brushes>
            </InteriorMap>
        </DetailLevel>
    </DetailLevels>
</ConstructorScene>
