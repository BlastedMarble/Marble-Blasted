<?xml version="1.0" encoding="utf-8" standalone="yes" ?>
<!--Torque Constructor Scene document http://www.garagegames.com-->
<ConstructorScene version="4" creator="Torque Constructor" date="2023/12/23 13:10:23">
    <Sunlight azimuth="180" elevation="35" color="100 100 100" ambient="64 64 64" />
    <LightingOptions lightingSystem="" ineditor_defaultLightmapSize="256" ineditor_maxLightmapSize="256" ineditor_lightingPerformanceHint="0" ineditor_shadowPerformanceHint="1" ineditor_TAPCompatibility="0" ineditor_useSunlight="0" export_defaultLightmapSize="256" export_maxLightmapSize="256" export_lightingPerformanceHint="0" export_shadowPerformanceHint="1" export_TAPCompatibility="0" export_useSunlight="0" />
    <GameTypes>
        <GameType name="Constructor" />
        <GameType name="Torque" />
    </GameTypes>
    <SceneShapes nextShapeID="19">
        <SceneShape id="0" type="1" entityID="2" dl="0" group="-1" locked="0" />
        <SceneShape id="1" type="1" entityID="3" dl="0" group="-1" locked="0" />
        <SceneShape id="2" type="1" entityID="6" dl="0" group="-1" locked="0" />
        <SceneShape id="3" type="1" entityID="7" dl="0" group="-1" locked="0" />
        <SceneShape id="4" type="1" entityID="10" dl="0" group="-1" locked="0" />
        <SceneShape id="5" type="1" entityID="11" dl="0" group="-1" locked="0" />
        <SceneShape id="6" type="1" entityID="14" dl="0" group="-1" locked="0" />
        <SceneShape id="7" type="1" entityID="15" dl="0" group="-1" locked="0" />
        <SceneShape id="8" type="1" entityID="18" dl="0" group="-1" locked="0" />
        <SceneShape id="9" type="1" entityID="19" dl="0" group="-1" locked="0" />
        <SceneShape id="10" type="1" entityID="22" dl="0" group="-1" locked="0" />
        <SceneShape id="11" type="1" entityID="23" dl="0" group="-1" locked="0" />
        <SceneShape id="12" type="1" entityID="26" dl="0" group="-1" locked="0" />
        <SceneShape id="13" type="1" entityID="27" dl="0" group="-1" locked="0" />
        <SceneShape id="14" type="1" entityID="30" dl="0" group="-1" locked="0" />
        <SceneShape id="15" type="1" entityID="31" dl="0" group="-1" locked="0" />
        <SceneShape id="16" type="1" entityID="34" dl="0" group="-1" locked="0" />
        <SceneShape id="17" type="1" entityID="35" dl="0" group="-1" locked="0" />
        <SceneShape id="18" type="1" entityID="36" dl="0" group="-1" locked="0" />
    </SceneShapes>
    <DetailLevels current="0">
        <DetailLevel minPixelSize="0" actionCenter="0 0 0">
            <InteriorMap brushScale="32" lightScale="8" ambientColor="0 0 0" ambientColorEmerg="0 0 0">
                <Entities nextEntityID="37">
                    <Entity id="0" classname="worldspawn" gametype="Torque" isPointEntity="0">
                        <Properties detail_number="0" min_pixels="250" geometry_scale="32" light_geometry_scale="8" light_smoothing_scale="4.0" light_mesh_scale="1.0" ambient_color="0 0 0" emergency_ambient_color="0 0 0" mapversion="220" />
                    </Entity>
                    <Entity id="1" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="0" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="2" classname="path_node" gametype="Torque" isPointEntity="1" origin="46 0 5.125" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="3" classname="path_node" gametype="Torque" isPointEntity="1" origin="46 0 5" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="4" classname="trigger" gametype="Torque" isPointEntity="0">
                        <Properties TargetTime="99999" datablock="TriggerGotoTarget" />
                    </Entity>
                    <Entity id="5" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="0" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="6" classname="path_node" gametype="Torque" isPointEntity="1" origin="0 50 7.125" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="7" classname="path_node" gametype="Torque" isPointEntity="1" origin="0 50 7" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="8" classname="trigger" gametype="Torque" isPointEntity="0">
                        <Properties TargetTime="99999" datablock="TriggerGotoTarget" />
                    </Entity>
                    <Entity id="9" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="0" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="10" classname="path_node" gametype="Torque" isPointEntity="1" origin="-46 0 -2.875" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="11" classname="path_node" gametype="Torque" isPointEntity="1" origin="-46 0 -3" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="12" classname="trigger" gametype="Torque" isPointEntity="0">
                        <Properties TargetTime="99999" datablock="TriggerGotoTarget" />
                    </Entity>
                    <Entity id="13" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="0" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="14" classname="path_node" gametype="Torque" isPointEntity="1" origin="0 -48 6.125" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="15" classname="path_node" gametype="Torque" isPointEntity="1" origin="0 -48 6" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="16" classname="trigger" gametype="Torque" isPointEntity="0">
                        <Properties TargetTime="99999" datablock="TriggerGotoTarget" />
                    </Entity>
                    <Entity id="17" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="0" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="18" classname="path_node" gametype="Torque" isPointEntity="1" origin="0 0 -11.5" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="19" classname="path_node" gametype="Torque" isPointEntity="1" origin="0 0 -16.25" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="20" classname="trigger" gametype="Torque" isPointEntity="0">
                        <Properties TargetTime="99999" datablock="TriggerGotoTarget" />
                    </Entity>
                    <Entity id="21" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="0" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="22" classname="path_node" gametype="Torque" isPointEntity="1" origin="0 0 -12" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="23" classname="path_node" gametype="Torque" isPointEntity="1" origin="0 0 -16.75" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="24" classname="trigger" gametype="Torque" isPointEntity="0">
                        <Properties TargetTime="99999" datablock="TriggerGotoTarget" />
                    </Entity>
                    <Entity id="25" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="0" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="26" classname="path_node" gametype="Torque" isPointEntity="1" origin="0 0 -12.5" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="27" classname="path_node" gametype="Torque" isPointEntity="1" origin="0 0 -17.25" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="28" classname="trigger" gametype="Torque" isPointEntity="0">
                        <Properties TargetTime="99999" datablock="TriggerGotoTarget" />
                    </Entity>
                    <Entity id="29" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="-1" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="30" classname="path_node" gametype="Torque" isPointEntity="1" origin="0 0 -13" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="31" classname="path_node" gametype="Torque" isPointEntity="1" origin="0 0 -17.75" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="32" classname="trigger" gametype="Torque" isPointEntity="0">
                        <Properties TargetTime="99999" datablock="TriggerGotoTarget" />
                    </Entity>
                    <Entity id="33" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="-1" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="34" classname="path_node" gametype="Torque" isPointEntity="1" origin="42 -4 -1.5" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="35" classname="path_node" gametype="Torque" isPointEntity="1" origin="42 -4 -8.5" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="36" classname="path_node" gametype="Torque" isPointEntity="1" origin="42 -4 -1.5" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                </Entities>
                <Brushes nextBrushID="174">
                    <Brush id="0" owner="0" type="0" pos="4.76837e-007 4 0.5" rot="1 0 0 0" scale="" transform="1 0 0 4.76837e-007 0 1 0 4 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 4 0.5" />
                            <Vertex pos="6 4 -0.5" />
                            <Vertex pos="10 -4 0.5" />
                            <Vertex pos="10 -4 -0.5" />
                            <Vertex pos="-6 4 0.5" />
                            <Vertex pos="-6 4 -0.5" />
                            <Vertex pos="-10 -4 0.5" />
                            <Vertex pos="-10 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0.894427 0.447214 0 -7.15542" album="" material="bm_grid_blank3" texgens="0 1 0 1024 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.894427 0.447214 0 -7.15542" album="" material="bm_grid_blank3" texgens="0 -1 0 -512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 0.00012207 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile09_A" texgens="1 0 0 0.00012207 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="1" owner="0" type="0" pos="4.76837e-007 4 -1" rot="1 0 0 0" scale="" transform="1 0 0 4.76837e-007 0 1 0 4 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 4 1" />
                            <Vertex pos="6 4 -1" />
                            <Vertex pos="10 -4 1" />
                            <Vertex pos="10 -4 -1" />
                            <Vertex pos="-6 4 1" />
                            <Vertex pos="-6 4 -1" />
                            <Vertex pos="-10 -4 1" />
                            <Vertex pos="-10 -4 -1" />
                        </Vertices>
                        <Face id="0" plane="0.894427 0.447214 0 -7.15542" album="" material="bm_grid_blank4" texgens="0 1 0 512 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.894427 0.447214 0 -7.15542" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="2" owner="0" type="0" pos="-4.76837e-007 -4 0.5" rot="1 0 0 0" scale="" transform="1 0 0 -4.76837e-007 0 1 0 -4 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="10 4 0.5" />
                            <Vertex pos="10 4 -0.5" />
                            <Vertex pos="6 -4 0.5" />
                            <Vertex pos="6 -4 -0.5" />
                            <Vertex pos="-10 4 0.5" />
                            <Vertex pos="-10 4 -0.5" />
                            <Vertex pos="-6 -4 0.5" />
                            <Vertex pos="-6 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0.894427 -0.447214 0 -7.15542" album="" material="bm_grid_blank3" texgens="0 1 0 1024 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.894427 -0.447214 0 -7.15542" album="" material="bm_grid_blank3" texgens="0 -1 0 -512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 -0.00012207 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile09_A" texgens="1 0 0 -0.00012207 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="3" owner="0" type="0" pos="-4.76837e-007 -4 -1" rot="1 0 0 0" scale="" transform="1 0 0 -4.76837e-007 0 1 0 -4 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="10 4 1" />
                            <Vertex pos="10 4 -1" />
                            <Vertex pos="6 -4 1" />
                            <Vertex pos="6 -4 -1" />
                            <Vertex pos="-10 4 1" />
                            <Vertex pos="-10 4 -1" />
                            <Vertex pos="-6 -4 1" />
                            <Vertex pos="-6 -4 -1" />
                        </Vertices>
                        <Face id="0" plane="0.894427 -0.447214 0 -7.15542" album="" material="bm_grid_blank4" texgens="0 1 0 512 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.894427 -0.447214 0 -7.15542" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="4" owner="0" type="0" pos="0 34 -3.5" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 34 0 0 1 -3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 0.5" />
                            <Vertex pos="4 2 -0.5" />
                            <Vertex pos="4 -2 0.5" />
                            <Vertex pos="4 -2 -0.5" />
                            <Vertex pos="-4 2 0.5" />
                            <Vertex pos="-4 2 -0.5" />
                            <Vertex pos="-4 -2 0.5" />
                            <Vertex pos="-4 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank3" texgens="0 -1 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile06_A" texgens="1 0 0 0 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="5" owner="0" type="0" pos="0 34 -5" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 34 0 0 1 -5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 1" />
                            <Vertex pos="4 2 -1" />
                            <Vertex pos="4 -2 1" />
                            <Vertex pos="4 -2 -1" />
                            <Vertex pos="-4 2 1" />
                            <Vertex pos="-4 2 -1" />
                            <Vertex pos="-4 -2 1" />
                            <Vertex pos="-4 -2 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="6" owner="0" type="0" pos="9 36 -3.5" rot="1 0 0 0" scale="" transform="1 0 0 9 0 1 0 36 0 0 1 -3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 4 0.5" />
                            <Vertex pos="5 4 -0.5" />
                            <Vertex pos="-3 -4 0.5" />
                            <Vertex pos="-3 -4 -0.5" />
                            <Vertex pos="-5 4 0.5" />
                            <Vertex pos="-5 4 -0.5" />
                            <Vertex pos="-5 -4 0.5" />
                            <Vertex pos="-5 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 -0.707107" album="" material="bm_grid_blank3" texgens="0 1 0 1024 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -5" album="" material="bm_grid_blank3" texgens="0 -1 0 -512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 -1792 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 2304 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile06_A" texgens="1 0 0 2304 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 -1792 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="7" owner="0" type="0" pos="9 36 -5" rot="1 0 0 0" scale="" transform="1 0 0 9 0 1 0 36 0 0 1 -5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 4 1" />
                            <Vertex pos="5 4 -1" />
                            <Vertex pos="-3 -4 1" />
                            <Vertex pos="-3 -4 -1" />
                            <Vertex pos="-5 4 1" />
                            <Vertex pos="-5 4 -1" />
                            <Vertex pos="-5 -4 1" />
                            <Vertex pos="-5 -4 -1" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 -0.707107" album="" material="bm_grid_blank4" texgens="0 1 0 512 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -5" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -896 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 1152 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_grid_blank4" texgens="1 0 0 1152 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -896 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="8" owner="0" type="0" pos="-9 36 -3.5" rot="1 0 0 0" scale="" transform="1 0 0 -9 0 1 0 36 0 0 1 -3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 4 0.5" />
                            <Vertex pos="5 4 -0.5" />
                            <Vertex pos="5 -4 0.5" />
                            <Vertex pos="5 -4 -0.5" />
                            <Vertex pos="-5 4 0.5" />
                            <Vertex pos="-5 4 -0.5" />
                            <Vertex pos="3 -4 0.5" />
                            <Vertex pos="3 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_grid_blank3" texgens="0 1 0 1024 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -0.707107" album="" material="bm_grid_blank3" texgens="0 -1 0 -512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile06_A" texgens="1 0 0 256 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 256 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="9" owner="0" type="0" pos="-9 36 -5" rot="1 0 0 0" scale="" transform="1 0 0 -9 0 1 0 36 0 0 1 -5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 4 1" />
                            <Vertex pos="5 4 -1" />
                            <Vertex pos="5 -4 1" />
                            <Vertex pos="5 -4 -1" />
                            <Vertex pos="-5 4 1" />
                            <Vertex pos="-5 4 -1" />
                            <Vertex pos="3 -4 1" />
                            <Vertex pos="3 -4 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_grid_blank4" texgens="0 1 0 512 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -0.707107" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="10" owner="0" type="0" pos="0 38 -2.5" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 38 0 0 1 -2.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 1.5" />
                            <Vertex pos="4 2 0.5" />
                            <Vertex pos="4 -2 -0.5" />
                            <Vertex pos="4 -2 -1.5" />
                            <Vertex pos="-4 2 1.5" />
                            <Vertex pos="-4 2 0.5" />
                            <Vertex pos="-4 -2 -0.5" />
                            <Vertex pos="-4 -2 -1.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank3" texgens="0 1 0 -256 0 0.5 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -4" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0.5 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 0 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.447214 0.894427 -0.447214" album="" material="bm_friction_ice" texgens="1 0 0 0 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.447214 -0.894427 -0.447214" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="11" owner="0" type="0" pos="0 38 -4" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 38 0 0 1 -4 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 2" />
                            <Vertex pos="4 2 -2" />
                            <Vertex pos="4 -2 0" />
                            <Vertex pos="4 -2 -2" />
                            <Vertex pos="-4 2 2" />
                            <Vertex pos="-4 2 -2" />
                            <Vertex pos="-4 -2 0" />
                            <Vertex pos="-4 -2 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.447214 0.894427 -0.894427" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="12" owner="0" type="0" pos="6 44 -2.5" rot="1 0 0 0" scale="" transform="1 0 0 6 0 1 0 44 0 0 1 -2.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 -0.5" />
                            <Vertex pos="2 4 -1.5" />
                            <Vertex pos="2 -4 -0.5" />
                            <Vertex pos="2 -4 -1.5" />
                            <Vertex pos="-2 4 1.5" />
                            <Vertex pos="-2 4 0.5" />
                            <Vertex pos="-2 -4 1.5" />
                            <Vertex pos="-2 -4 0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 1024 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 -512 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 -256 -0.5 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 -256 -0.5 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.447214 0 0.894427 -0.447214" album="" material="bm_friction_ice" texgens="1 0 0 512 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.447214 0 -0.894427 -0.447214" album="" material="bm_grid_blank3" texgens="-1 0 0 0 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="13" owner="0" type="0" pos="6 44 -4" rot="1 0 0 0" scale="" transform="1 0 0 6 0 1 0 44 0 0 1 -4 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 0" />
                            <Vertex pos="2 4 -2" />
                            <Vertex pos="2 -4 0" />
                            <Vertex pos="2 -4 -2" />
                            <Vertex pos="-2 4 2" />
                            <Vertex pos="-2 4 -2" />
                            <Vertex pos="-2 -4 2" />
                            <Vertex pos="-2 -4 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 512 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 256 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.447214 0 0.894427 -0.894427" album="" material="bm_grid_blank4" texgens="1 0 0 256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="14" owner="0" type="0" pos="-6 44 -2.5" rot="1 0 0 0" scale="" transform="1 0 0 -6 0 1 0 44 0 0 1 -2.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 1.5" />
                            <Vertex pos="2 4 0.5" />
                            <Vertex pos="2 -4 1.5" />
                            <Vertex pos="2 -4 0.5" />
                            <Vertex pos="-2 4 -0.5" />
                            <Vertex pos="-2 4 -1.5" />
                            <Vertex pos="-2 -4 -0.5" />
                            <Vertex pos="-2 -4 -1.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 1024 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 -512 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 -256 0.5 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 -256 0.5 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.447214 0 0.894427 -0.447214" album="" material="bm_friction_ice" texgens="1 0 0 512 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.447214 0 -0.894427 -0.447214" album="" material="bm_grid_blank3" texgens="-1 0 0 0 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="15" owner="0" type="0" pos="-6 44 -4" rot="1 0 0 0" scale="" transform="1 0 0 -6 0 1 0 44 0 0 1 -4 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 2" />
                            <Vertex pos="2 4 -2" />
                            <Vertex pos="2 -4 2" />
                            <Vertex pos="2 -4 -2" />
                            <Vertex pos="-2 4 0" />
                            <Vertex pos="-2 4 -2" />
                            <Vertex pos="-2 -4 0" />
                            <Vertex pos="-2 -4 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 512 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 256 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.447214 0 0.894427 -0.894427" album="" material="bm_grid_blank4" texgens="1 0 0 256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="16" owner="0" type="0" pos="0 44 -4" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 44 0 0 1 -4 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 2" />
                            <Vertex pos="4 4 -2" />
                            <Vertex pos="4 -4 2" />
                            <Vertex pos="4 -4 -2" />
                            <Vertex pos="-4 4 2" />
                            <Vertex pos="-4 4 -2" />
                            <Vertex pos="-4 -4 2" />
                            <Vertex pos="-4 -4 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 512 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="17" owner="0" type="0" pos="0 44 -1.5" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 44 0 0 1 -1.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 0.5" />
                            <Vertex pos="4 4 -0.5" />
                            <Vertex pos="4 -4 0.5" />
                            <Vertex pos="4 -4 -0.5" />
                            <Vertex pos="-4 4 0.5" />
                            <Vertex pos="-4 4 -0.5" />
                            <Vertex pos="-4 -4 0.5" />
                            <Vertex pos="-4 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank3" texgens="0 1 0 1024 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank3" texgens="0 -1 0 -512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_friction_ice" texgens="1 0 0 0 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="18" owner="0" type="0" pos="0 52 0" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 52 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 4" />
                            <Vertex pos="4 4 -6" />
                            <Vertex pos="4 -4 4" />
                            <Vertex pos="4 -4 -6" />
                            <Vertex pos="-4 4 4" />
                            <Vertex pos="-4 4 -6" />
                            <Vertex pos="-4 -4 4" />
                            <Vertex pos="-4 -4 -6" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 512 0 0 -1 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -6" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="19" owner="0" type="0" pos="0 55 4.5" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 55 0 0 1 4.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 1 0.5" />
                            <Vertex pos="4 1 -0.5" />
                            <Vertex pos="4 -1 0.5" />
                            <Vertex pos="4 -1 -0.5" />
                            <Vertex pos="-4 1 0.5" />
                            <Vertex pos="-4 1 -0.5" />
                            <Vertex pos="-4 -1 0.5" />
                            <Vertex pos="-4 -1 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank3" texgens="0 1 0 1792 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank3" texgens="0 -1 0 -1280 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank3" texgens="1 0 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_friction_ice" texgens="1 0 0 0 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="20" owner="0" type="0" pos="-11 44 -3.5" rot="1 0 0 0" scale="" transform="1 0 0 -11 0 1 0 44 0 0 1 -3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 4 0.5" />
                            <Vertex pos="3 4 -0.5" />
                            <Vertex pos="3 -4 0.5" />
                            <Vertex pos="3 -4 -0.5" />
                            <Vertex pos="-3 4 0.5" />
                            <Vertex pos="-3 4 -0.5" />
                            <Vertex pos="-3 -4 0.5" />
                            <Vertex pos="-3 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank3" texgens="0 1 0 1024 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank3" texgens="0 -1 0 -512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile06_A" texgens="1 0 0 256 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 256 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="21" owner="0" type="0" pos="-11 44 -5" rot="1 0 0 0" scale="" transform="1 0 0 -11 0 1 0 44 0 0 1 -5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 4 1" />
                            <Vertex pos="3 4 -1" />
                            <Vertex pos="3 -4 1" />
                            <Vertex pos="3 -4 -1" />
                            <Vertex pos="-3 4 1" />
                            <Vertex pos="-3 4 -1" />
                            <Vertex pos="-3 -4 1" />
                            <Vertex pos="-3 -4 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 512 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="22" owner="0" type="0" pos="-9 52 -3.5" rot="1 0 0 0" scale="" transform="1 0 0 -9 0 1 0 52 0 0 1 -3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 4 0.5" />
                            <Vertex pos="5 4 -0.5" />
                            <Vertex pos="5 -4 0.5" />
                            <Vertex pos="5 -4 -0.5" />
                            <Vertex pos="-0.999999 4 0.5" />
                            <Vertex pos="-0.999999 4 -0.5" />
                            <Vertex pos="-5 -4 0.5" />
                            <Vertex pos="-5 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_grid_blank3" texgens="0 1 0 1024 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.894427 0.447214 0 -2.68328" album="" material="bm_grid_blank3" texgens="0 -1 0 -512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 768 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile06_A" texgens="1 0 0 768 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 -256 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="23" owner="0" type="0" pos="-9 52 -5" rot="1 0 0 0" scale="" transform="1 0 0 -9 0 1 0 52 0 0 1 -5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 4 1" />
                            <Vertex pos="5 4 -1" />
                            <Vertex pos="5 -4 1" />
                            <Vertex pos="5 -4 -1" />
                            <Vertex pos="-0.999999 4 1" />
                            <Vertex pos="-0.999999 4 -1" />
                            <Vertex pos="-5 -4 1" />
                            <Vertex pos="-5 -4 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_grid_blank4" texgens="0 1 0 512 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.894427 0.447214 0 -2.68328" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 384 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_grid_blank4" texgens="1 0 0 384 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="24" owner="0" type="0" pos="9 52 -3.5" rot="1 0 0 0" scale="" transform="1 0 0 9 0 1 0 52 0 0 1 -3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.999999 4 0.5" />
                            <Vertex pos="0.999999 4 -0.5" />
                            <Vertex pos="5 -4 0.5" />
                            <Vertex pos="5 -4 -0.5" />
                            <Vertex pos="-5 4 0.5" />
                            <Vertex pos="-5 4 -0.5" />
                            <Vertex pos="-5 -4 0.5" />
                            <Vertex pos="-5 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0.894427 0.447214 0 -2.68328" album="" material="bm_grid_blank3" texgens="0 1 0 1024 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -5" album="" material="bm_grid_blank3" texgens="0 -1 0 -512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 768 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile06_A" texgens="1 0 0 768 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 -256 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="25" owner="0" type="0" pos="9 52 -5" rot="1 0 0 0" scale="" transform="1 0 0 9 0 1 0 52 0 0 1 -5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.999999 4 1" />
                            <Vertex pos="0.999999 4 -1" />
                            <Vertex pos="5 -4 1" />
                            <Vertex pos="5 -4 -1" />
                            <Vertex pos="-5 4 1" />
                            <Vertex pos="-5 4 -1" />
                            <Vertex pos="-5 -4 1" />
                            <Vertex pos="-5 -4 -1" />
                        </Vertices>
                        <Face id="0" plane="0.894427 0.447214 0 -2.68328" album="" material="bm_grid_blank4" texgens="0 1 0 512 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -5" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 384 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_grid_blank4" texgens="1 0 0 384 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="26" owner="0" type="0" pos="11 44 -3.5" rot="1 0 0 0" scale="" transform="1 0 0 11 0 1 0 44 0 0 1 -3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 4 0.5" />
                            <Vertex pos="3 4 -0.5" />
                            <Vertex pos="3 -4 0.5" />
                            <Vertex pos="3 -4 -0.5" />
                            <Vertex pos="-3 4 0.5" />
                            <Vertex pos="-3 4 -0.5" />
                            <Vertex pos="-3 -4 0.5" />
                            <Vertex pos="-3 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank3" texgens="0 1 0 1024 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank3" texgens="0 -1 0 -512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile06_A" texgens="1 0 0 256 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 256 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="27" owner="0" type="0" pos="11 44 -5" rot="1 0 0 0" scale="" transform="1 0 0 11 0 1 0 44 0 0 1 -5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 4 1" />
                            <Vertex pos="3 4 -1" />
                            <Vertex pos="3 -4 1" />
                            <Vertex pos="3 -4 -1" />
                            <Vertex pos="-3 4 1" />
                            <Vertex pos="-3 4 -1" />
                            <Vertex pos="-3 -4 1" />
                            <Vertex pos="-3 -4 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 512 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="28" owner="0" type="0" pos="36 0 -7.5" rot="1 0 0 0" scale="" transform="1 0 0 36 0 1 0 0 0 0 1 -7.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 14 0.5" />
                            <Vertex pos="4 14 -0.5" />
                            <Vertex pos="4 -14 0.5" />
                            <Vertex pos="4 -14 -0.5" />
                            <Vertex pos="-4 6 0.5" />
                            <Vertex pos="-4 6 -0.5" />
                            <Vertex pos="-4 -6 0.5" />
                            <Vertex pos="-4 -6 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank3" texgens="0 1 0 1024 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank3" texgens="0 -1 0 -512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -7.07107" album="" material="bm_grid_blank3" texgens="-1 0 0 1024 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -7.07107" album="" material="bm_grid_blank3" texgens="1 0 0 -512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile07_A" texgens="1 0 0 -512 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 1024 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="29" owner="0" type="0" pos="36 0 -9" rot="1 0 0 0" scale="" transform="1 0 0 36 0 1 0 0 0 0 1 -9 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 14 1" />
                            <Vertex pos="4 14 -1" />
                            <Vertex pos="4 -14 1" />
                            <Vertex pos="4 -14 -1" />
                            <Vertex pos="-4 6 1" />
                            <Vertex pos="-4 6 -1" />
                            <Vertex pos="-4 -6 1" />
                            <Vertex pos="-4 -6 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 512 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -7.07107" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -7.07107" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="30" owner="33" type="999" pos="42 -4 -1.5" rot="1 0 0 0" scale="" transform="1 0 0 42 0 1 0 -4 0 0 1 -1.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.5" />
                            <Vertex pos="2 2 -0.5" />
                            <Vertex pos="2 -2 0.5" />
                            <Vertex pos="2 -2 -0.5" />
                            <Vertex pos="-2 2 0.5" />
                            <Vertex pos="-2 2 -0.5" />
                            <Vertex pos="-2 -2 0.5" />
                            <Vertex pos="-2 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 1536 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 -1024 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile11_C" texgens="1 0 0 -1024 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 1536 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="31" owner="33" type="999" pos="42 -4 -6" rot="1 0 0 0" scale="" transform="1 0 0 42 0 1 0 -4 0 0 1 -6 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 4" />
                            <Vertex pos="2 2 -4" />
                            <Vertex pos="2 -2 4" />
                            <Vertex pos="2 -2 -4" />
                            <Vertex pos="-2 2 4" />
                            <Vertex pos="-2 2 -4" />
                            <Vertex pos="-2 -2 4" />
                            <Vertex pos="-2 -2 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -512 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -512 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="32" owner="0" type="0" pos="46 0 4.5" rot="1 0 0 0" scale="" transform="1 0 0 46 0 1 0 0 0 0 1 4.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.5" />
                            <Vertex pos="2 2 -0.5" />
                            <Vertex pos="2 -2 0.5" />
                            <Vertex pos="2 -2 -0.5" />
                            <Vertex pos="-2 2 0.5" />
                            <Vertex pos="-2 2 -0.5" />
                            <Vertex pos="-2 -2 0.5" />
                            <Vertex pos="-2 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 1536 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 -1024 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile07_A" texgens="1 0 0 -1024 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 1536 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="33" owner="0" type="0" pos="46 0 -3" rot="1 0 0 0" scale="" transform="1 0 0 46 0 1 0 0 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 7" />
                            <Vertex pos="2 2 -7" />
                            <Vertex pos="2 -2 7" />
                            <Vertex pos="2 -2 -7" />
                            <Vertex pos="-2 2 7" />
                            <Vertex pos="-2 2 -7" />
                            <Vertex pos="-2 -2 7" />
                            <Vertex pos="-2 -2 -7" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -512 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -7" album="" material="bm_grid_blank4" texgens="1 0 0 -512 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -7" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="34" owner="0" type="0" pos="44 -10 -7.5" rot="1 0 0 0" scale="" transform="1 0 0 44 0 1 0 -10 0 0 1 -7.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 0.5" />
                            <Vertex pos="4 4 -0.5" />
                            <Vertex pos="4 -4 0.5" />
                            <Vertex pos="4 -4 -0.5" />
                            <Vertex pos="-4 4 0.5" />
                            <Vertex pos="-4 4 -0.5" />
                            <Vertex pos="-4 -4 0.5" />
                            <Vertex pos="-4 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank3" texgens="0 1 0 1536 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank3" texgens="0 -1 0 -1024 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 1024 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 -512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile07_A" texgens="1 0 0 -512 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 1024 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="35" owner="0" type="0" pos="44 -10 -9" rot="1 0 0 0" scale="" transform="1 0 0 44 0 1 0 -10 0 0 1 -9 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 1" />
                            <Vertex pos="4 4 -1" />
                            <Vertex pos="4 -4 1" />
                            <Vertex pos="4 -4 -1" />
                            <Vertex pos="-4 4 1" />
                            <Vertex pos="-4 4 -1" />
                            <Vertex pos="-4 -4 1" />
                            <Vertex pos="-4 -4 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="36" owner="0" type="0" pos="50 0 -1.5" rot="1 0 0 0" scale="" transform="1 0 0 50 0 1 0 0 0 0 1 -1.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.5" />
                            <Vertex pos="2 2 -0.5" />
                            <Vertex pos="2 -2 0.5" />
                            <Vertex pos="2 -2 -0.5" />
                            <Vertex pos="-2 2 0.5" />
                            <Vertex pos="-2 2 -0.5" />
                            <Vertex pos="-2 -2 0.5" />
                            <Vertex pos="-2 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 1536 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 -1024 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile07_A" texgens="1 0 0 -1024 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 1536 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="37" owner="0" type="0" pos="50 0 -6" rot="1 0 0 0" scale="" transform="1 0 0 50 0 1 0 0 0 0 1 -6 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 4" />
                            <Vertex pos="2 2 -4" />
                            <Vertex pos="2 -2 4" />
                            <Vertex pos="2 -2 -4" />
                            <Vertex pos="-2 2 4" />
                            <Vertex pos="-2 2 -4" />
                            <Vertex pos="-2 -2 4" />
                            <Vertex pos="-2 -2 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -512 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -512 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="38" owner="0" type="0" pos="44 10 -7.5" rot="1 0 0 0" scale="" transform="1 0 0 44 0 1 0 10 0 0 1 -7.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 0.5" />
                            <Vertex pos="4 4 -0.5" />
                            <Vertex pos="4 -4 0.5" />
                            <Vertex pos="4 -4 -0.5" />
                            <Vertex pos="-4 4 0.5" />
                            <Vertex pos="-4 4 -0.5" />
                            <Vertex pos="-4 -4 0.5" />
                            <Vertex pos="-4 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank3" texgens="0 1 0 1536 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank3" texgens="0 -1 0 -1024 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 1024 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 -512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile07_A" texgens="1 0 0 -512 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 1024 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="39" owner="0" type="0" pos="44 10 -9" rot="1 0 0 0" scale="" transform="1 0 0 44 0 1 0 10 0 0 1 -9 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 1" />
                            <Vertex pos="4 4 -1" />
                            <Vertex pos="4 -4 1" />
                            <Vertex pos="4 -4 -1" />
                            <Vertex pos="-4 4 1" />
                            <Vertex pos="-4 4 -1" />
                            <Vertex pos="-4 -4 1" />
                            <Vertex pos="-4 -4 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="40" owner="0" type="0" pos="0 -34 -3.5" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -34 0 0 1 -3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 0.5" />
                            <Vertex pos="4 2 -0.5" />
                            <Vertex pos="4 -2 0.5" />
                            <Vertex pos="4 -2 -0.5" />
                            <Vertex pos="-4 2 0.5" />
                            <Vertex pos="-4 2 -0.5" />
                            <Vertex pos="-4 -2 0.5" />
                            <Vertex pos="-4 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank3" texgens="0 -1 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile01_A" texgens="1 0 0 0 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="41" owner="0" type="0" pos="0 -34 -5" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -34 0 0 1 -5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 1" />
                            <Vertex pos="4 2 -1" />
                            <Vertex pos="4 -2 1" />
                            <Vertex pos="4 -2 -1" />
                            <Vertex pos="-4 2 1" />
                            <Vertex pos="-4 2 -1" />
                            <Vertex pos="-4 -2 1" />
                            <Vertex pos="-4 -2 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="42" owner="0" type="0" pos="-9 -36 -3.5" rot="1 0 0 0" scale="" transform="1 0 0 -9 0 1 0 -36 0 0 1 -3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 4 0.5" />
                            <Vertex pos="5 4 -0.5" />
                            <Vertex pos="5 -4 0.5" />
                            <Vertex pos="5 -4 -0.5" />
                            <Vertex pos="3 4 0.5" />
                            <Vertex pos="3 4 -0.5" />
                            <Vertex pos="-5 -4 0.5" />
                            <Vertex pos="-5 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_grid_blank3" texgens="0 1 0 1024 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 -0.707107" album="" material="bm_grid_blank3" texgens="0 -1 0 -512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 768 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile01_A" texgens="1 0 0 768 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 -256 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="43" owner="0" type="0" pos="-9 -36 -5" rot="1 0 0 0" scale="" transform="1 0 0 -9 0 1 0 -36 0 0 1 -5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 4 1" />
                            <Vertex pos="5 4 -1" />
                            <Vertex pos="5 -4 1" />
                            <Vertex pos="5 -4 -1" />
                            <Vertex pos="3 4 1" />
                            <Vertex pos="3 4 -1" />
                            <Vertex pos="-5 -4 1" />
                            <Vertex pos="-5 -4 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_grid_blank4" texgens="0 1 0 512 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 -0.707107" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 384 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_grid_blank4" texgens="1 0 0 384 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="44" owner="0" type="0" pos="9 -36 -3.5" rot="1 0 0 0" scale="" transform="1 0 0 9 0 1 0 -36 0 0 1 -3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-3 4 0.5" />
                            <Vertex pos="-3 4 -0.5" />
                            <Vertex pos="5 -4 0.5" />
                            <Vertex pos="5 -4 -0.5" />
                            <Vertex pos="-5 4 0.5" />
                            <Vertex pos="-5 4 -0.5" />
                            <Vertex pos="-5 -4 0.5" />
                            <Vertex pos="-5 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 -0.707107" album="" material="bm_grid_blank3" texgens="0 1 0 1024 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -5" album="" material="bm_grid_blank3" texgens="0 -1 0 -512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 768 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile01_A" texgens="1 0 0 768 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 -256 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="45" owner="0" type="0" pos="9 -36 -5" rot="1 0 0 0" scale="" transform="1 0 0 9 0 1 0 -36 0 0 1 -5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-3 4 1" />
                            <Vertex pos="-3 4 -1" />
                            <Vertex pos="5 -4 1" />
                            <Vertex pos="5 -4 -1" />
                            <Vertex pos="-5 4 1" />
                            <Vertex pos="-5 4 -1" />
                            <Vertex pos="-5 -4 1" />
                            <Vertex pos="-5 -4 -1" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 -0.707107" album="" material="bm_grid_blank4" texgens="0 1 0 512 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -5" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 384 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_grid_blank4" texgens="1 0 0 384 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="46" owner="0" type="0" pos="10 -46 -3.5" rot="1 0 0 0" scale="" transform="1 0 0 10 0 1 0 -46 0 0 1 -3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 6 0.5" />
                            <Vertex pos="4 6 -0.5" />
                            <Vertex pos="4 -2 0.5" />
                            <Vertex pos="4 -2 -0.5" />
                            <Vertex pos="-4 6 0.5" />
                            <Vertex pos="-4 6 -0.5" />
                            <Vertex pos="-4 -6 0.5" />
                            <Vertex pos="-4 -6 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank3" texgens="0 -1 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_grid_blank3" texgens="-1 0 0 1024 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.447214 -0.894427 0 -3.57771" album="" material="bm_grid_blank3" texgens="1 0 0 -512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile01_A" texgens="1 0 0 -512 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 1024 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="47" owner="0" type="0" pos="10 -46 -5" rot="1 0 0 0" scale="" transform="1 0 0 10 0 1 0 -46 0 0 1 -5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 6 1" />
                            <Vertex pos="4 6 -1" />
                            <Vertex pos="4 -2 1" />
                            <Vertex pos="4 -2 -1" />
                            <Vertex pos="-4 6 1" />
                            <Vertex pos="-4 6 -1" />
                            <Vertex pos="-4 -6 1" />
                            <Vertex pos="-4 -6 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.447214 -0.894427 0 -3.57771" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="48" owner="0" type="0" pos="-10 -46 -3.5" rot="1 0 0 0" scale="" transform="1 0 0 -10 0 1 0 -46 0 0 1 -3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 6 0.5" />
                            <Vertex pos="4 6 -0.5" />
                            <Vertex pos="4 -6 0.5" />
                            <Vertex pos="4 -6 -0.5" />
                            <Vertex pos="-4 6 0.5" />
                            <Vertex pos="-4 6 -0.5" />
                            <Vertex pos="-4 -2 0.5" />
                            <Vertex pos="-4 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank3" texgens="0 -1 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_grid_blank3" texgens="-1 0 0 1024 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.447214 -0.894427 -0 -3.57771" album="" material="bm_grid_blank3" texgens="1 0 0 -512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile01_A" texgens="1 0 0 -512 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 1024 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="49" owner="0" type="0" pos="-10 -46 -5" rot="1 0 0 0" scale="" transform="1 0 0 -10 0 1 0 -46 0 0 1 -5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 6 1" />
                            <Vertex pos="4 6 -1" />
                            <Vertex pos="4 -6 1" />
                            <Vertex pos="4 -6 -1" />
                            <Vertex pos="-4 6 1" />
                            <Vertex pos="-4 6 -1" />
                            <Vertex pos="-4 -2 1" />
                            <Vertex pos="-4 -2 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.447214 -0.894427 -0 -3.57771" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="50" owner="0" type="0" pos="-5 -41 -3.25" rot="1 0 0 0" scale="" transform="1 0 0 -5 0 1 0 -41 0 0 1 -3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 0.25" />
                            <Vertex pos="1 1 -0.75" />
                            <Vertex pos="1 -1 0.75" />
                            <Vertex pos="1 -1 -0.25" />
                            <Vertex pos="-1 1 0.25" />
                            <Vertex pos="-1 1 -0.75" />
                            <Vertex pos="-1 -1 0.75" />
                            <Vertex pos="-1 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -1" album="" material="bm_grid_blank3" texgens="0 1 0 1792 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3" texgens="0 -1 0 0 0 -0.25 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank3" texgens="-1 0 0 1792 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank3" texgens="1 0 0 -1280 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970143 -0.485071" album="" material="bm_friction_mud" texgens="1 0 0 -1280 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.242536 -0.970143 -0.485071" album="" material="bm_grid_blank3" texgens="-1 0 0 1792 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="51" owner="0" type="0" pos="-5 -41 -4.75" rot="1 0 0 0" scale="" transform="1 0 0 -5 0 1 0 -41 0 0 1 -4.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 0.75" />
                            <Vertex pos="1 1 -1.25" />
                            <Vertex pos="1 -1 1.25" />
                            <Vertex pos="1 -1 -1.25" />
                            <Vertex pos="-1 1 0.75" />
                            <Vertex pos="-1 1 -1.25" />
                            <Vertex pos="-1 -1 1.25" />
                            <Vertex pos="-1 -1 -1.25" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 896 0 0 -1 96 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 -640 0 0 -1 96 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 896 0 0 -1 96 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -640 0 0 -1 96 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970143 -0.970143" album="" material="bm_grid_blank4" texgens="1 0 0 -640 0 -1 0 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1.25" album="" material="bm_grid_blank4" texgens="-1 0 0 896 0 -1 0 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="52" owner="0" type="0" pos="-5 -45 -1.5" rot="1 0 0 0" scale="" transform="1 0 0 -5 0 1 0 -45 0 0 1 -1.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 -0.999999" />
                            <Vertex pos="1 3 -2" />
                            <Vertex pos="1 -3 2" />
                            <Vertex pos="1 -3 0.999999" />
                            <Vertex pos="-1 3 -0.999999" />
                            <Vertex pos="-1 3 -2" />
                            <Vertex pos="-1 -3 2" />
                            <Vertex pos="-1 -3 0.999999" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -1" album="" material="bm_grid_blank3" texgens="0 1 0 1280 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3" texgens="0 -1 0 -512 0 -0.5 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank3" texgens="-1 0 0 1792 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank3" texgens="1 0 0 -1280 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.447214 0.894427 -0.447214" album="" material="bm_friction_mud" texgens="1 0 0 -1280 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.447214 -0.894427 -0.447214" album="" material="bm_grid_blank3" texgens="-1 0 0 1792 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="53" owner="0" type="0" pos="-5 -49 0.249999" rot="1 0 0 0" scale="" transform="1 0 0 -5 0 1 0 -49 0 0 1 0.249999 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 0.25" />
                            <Vertex pos="1 1 -0.75" />
                            <Vertex pos="1 -1 0.75" />
                            <Vertex pos="1 -1 -0.250001" />
                            <Vertex pos="-1 1 0.25" />
                            <Vertex pos="-1 1 -0.75" />
                            <Vertex pos="-1 -1 0.75" />
                            <Vertex pos="-1 -1 -0.250001" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -1" album="" material="bm_grid_blank3" texgens="0 1 0 1792 0 0 -1 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3" texgens="0 -1 0 0 0 -0.25 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank3" texgens="-1 0 0 1792 0 0 -1 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank3" texgens="1 0 0 -1280 0 0 -1 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970143 -0.485071" album="" material="bm_friction_mud" texgens="1 0 0 -1280 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.242535 -0.970143 -0.485072" album="" material="bm_grid_blank3" texgens="-1 0 0 1792 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="54" owner="0" type="0" pos="5 -41 -3.25" rot="1 0 0 0" scale="" transform="1 0 0 5 0 1 0 -41 0 0 1 -3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 0.25" />
                            <Vertex pos="1 1 -0.75" />
                            <Vertex pos="1 -1 0.75" />
                            <Vertex pos="1 -1 -0.25" />
                            <Vertex pos="-1 1 0.25" />
                            <Vertex pos="-1 1 -0.75" />
                            <Vertex pos="-1 -1 0.75" />
                            <Vertex pos="-1 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -1" album="" material="bm_grid_blank3" texgens="0 1 0 0 0 -0.25 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3" texgens="0 -1 0 -1280 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank3" texgens="-1 0 0 1792 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank3" texgens="1 0 0 -1280 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970143 -0.485071" album="" material="bm_friction_mud" texgens="1 0 0 -1280 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.242536 -0.970143 -0.485071" album="" material="bm_grid_blank3" texgens="-1 0 0 1792 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="55" owner="0" type="0" pos="5 -45 -1.5" rot="1 0 0 0" scale="" transform="1 0 0 5 0 1 0 -45 0 0 1 -1.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 -0.999999" />
                            <Vertex pos="1 3 -2" />
                            <Vertex pos="1 -3 2" />
                            <Vertex pos="1 -3 0.999999" />
                            <Vertex pos="-1 3 -0.999999" />
                            <Vertex pos="-1 3 -2" />
                            <Vertex pos="-1 -3 2" />
                            <Vertex pos="-1 -3 0.999999" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -1" album="" material="bm_grid_blank3" texgens="0 1 0 -512 0 -0.5 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3" texgens="0 -1 0 -768 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank3" texgens="-1 0 0 1792 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank3" texgens="1 0 0 -1280 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.447214 0.894427 -0.447214" album="" material="bm_friction_mud" texgens="1 0 0 -1280 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.447214 -0.894427 -0.447214" album="" material="bm_grid_blank3" texgens="-1 0 0 1792 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="56" owner="0" type="0" pos="5 -49 0.249999" rot="1 0 0 0" scale="" transform="1 0 0 5 0 1 0 -49 0 0 1 0.249999 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 0.25" />
                            <Vertex pos="1 1 -0.75" />
                            <Vertex pos="1 -1 0.75" />
                            <Vertex pos="1 -1 -0.250001" />
                            <Vertex pos="-1 1 0.25" />
                            <Vertex pos="-1 1 -0.75" />
                            <Vertex pos="-1 -1 0.75" />
                            <Vertex pos="-1 -1 -0.250001" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -1" album="" material="bm_grid_blank3" texgens="0 1 0 0 0 -0.25 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3" texgens="0 -1 0 -1280 0 0 -1 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank3" texgens="-1 0 0 1792 0 0 -1 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank3" texgens="1 0 0 -1280 0 0 -1 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970143 -0.485071" album="" material="bm_friction_mud" texgens="1 0 0 -1280 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.242535 -0.970143 -0.485072" album="" material="bm_grid_blank3" texgens="-1 0 0 1792 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="57" owner="0" type="0" pos="0 -54 0.5" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -54 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 4 0.5" />
                            <Vertex pos="6 4 -0.5" />
                            <Vertex pos="6 -4 0.5" />
                            <Vertex pos="6 -4 -0.5" />
                            <Vertex pos="-6 4 0.5" />
                            <Vertex pos="-6 4 -0.5" />
                            <Vertex pos="-6 -4 0.5" />
                            <Vertex pos="-6 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank3" texgens="0 1 0 1024 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank3" texgens="0 -1 0 -512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile01_A" texgens="1 0 0 0 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="58" owner="0" type="0" pos="3 -49 0.750003" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 -49 0 0 1 0.750003 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 0.750001" />
                            <Vertex pos="1 1 -0.250001" />
                            <Vertex pos="1 -1 0.250001" />
                            <Vertex pos="1 -1 -0.750001" />
                            <Vertex pos="-1 1 0.750001" />
                            <Vertex pos="-1 1 -0.250001" />
                            <Vertex pos="-1 -1 0.250001" />
                            <Vertex pos="-1 -1 -0.750001" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3" texgens="0 1 0 0 0 0.25 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -1" album="" material="bm_grid_blank3" texgens="0 -1 0 256 0 0 -1 63.999 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank3" texgens="-1 0 0 -256 0 0 -1 63.999 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank3" texgens="1 0 0 768 0 0 -1 63.999 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.242536 0.970143 -0.485072" album="" material="bm_friction_mud" texgens="1 0 0 768 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.242536 -0.970143 -0.485072" album="" material="bm_grid_blank3" texgens="-1 0 0 -256 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="59" owner="0" type="0" pos="3 -46 2" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 -46 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 1.5" />
                            <Vertex pos="1 2 0.499998" />
                            <Vertex pos="1 -2 -0.5" />
                            <Vertex pos="1 -2 -1.5" />
                            <Vertex pos="-1 2 1.5" />
                            <Vertex pos="-1 2 0.499998" />
                            <Vertex pos="-1 -2 -0.5" />
                            <Vertex pos="-1 -2 -1.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3" texgens="0 1 0 -256 0 0.5 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -1" album="" material="bm_grid_blank3" texgens="0 -1 0 0 0 0 -1 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 -256 0 0 -1 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 768 0 0 -1 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.447214 0.894427 -0.447214" album="" material="bm_friction_mud" texgens="1 0 0 768 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.447213 -0.894427 -0.447215" album="" material="bm_grid_blank3" texgens="-1 0 0 -256 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="60" owner="0" type="0" pos="3 -43 3.25" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 -43 0 0 1 3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 0.75" />
                            <Vertex pos="1 1 -0.25" />
                            <Vertex pos="1 -1 0.25" />
                            <Vertex pos="1 -1 -0.75" />
                            <Vertex pos="-1 1 0.75" />
                            <Vertex pos="-1 1 -0.25" />
                            <Vertex pos="-1 -1 0.25" />
                            <Vertex pos="-1 -1 -0.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3" texgens="0 1 0 0 0 0.25 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -1" album="" material="bm_grid_blank3" texgens="0 -1 0 256 0 0 -1 -576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank3" texgens="-1 0 0 -256 0 0 -1 -576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank3" texgens="1 0 0 768 0 0 -1 -576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.242536 0.970143 -0.485071" album="" material="bm_friction_mud" texgens="1 0 0 768 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.242536 -0.970143 -0.485071" album="" material="bm_grid_blank3" texgens="-1 0 0 -256 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="61" owner="0" type="0" pos="-3 -49 0.750003" rot="1 0 0 0" scale="" transform="1 0 0 -3 0 1 0 -49 0 0 1 0.750003 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 0.750001" />
                            <Vertex pos="1 1 -0.250001" />
                            <Vertex pos="1 -1 0.250001" />
                            <Vertex pos="1 -1 -0.750001" />
                            <Vertex pos="-1 1 0.750001" />
                            <Vertex pos="-1 1 -0.250001" />
                            <Vertex pos="-1 -1 0.250001" />
                            <Vertex pos="-1 -1 -0.750001" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3" texgens="0 1 0 256 0 0 -1 63.999 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -1" album="" material="bm_grid_blank3" texgens="0 -1 0 0 0 0.25 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank3" texgens="-1 0 0 -256 0 0 -1 63.999 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank3" texgens="1 0 0 768 0 0 -1 63.999 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.242536 0.970143 -0.485072" album="" material="bm_friction_mud" texgens="1 0 0 768 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.242536 -0.970143 -0.485072" album="" material="bm_grid_blank3" texgens="-1 0 0 -256 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="62" owner="0" type="0" pos="-3 -46 2" rot="1 0 0 0" scale="" transform="1 0 0 -3 0 1 0 -46 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 1.5" />
                            <Vertex pos="1 2 0.499998" />
                            <Vertex pos="1 -2 -0.5" />
                            <Vertex pos="1 -2 -1.5" />
                            <Vertex pos="-1 2 1.5" />
                            <Vertex pos="-1 2 0.499998" />
                            <Vertex pos="-1 -2 -0.5" />
                            <Vertex pos="-1 -2 -1.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -1" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0.5 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 -256 0 0 -1 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 768 0 0 -1 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.447214 0.894427 -0.447214" album="" material="bm_friction_mud" texgens="1 0 0 768 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.447213 -0.894427 -0.447215" album="" material="bm_grid_blank3" texgens="-1 0 0 -256 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="63" owner="0" type="0" pos="-3 -43 3.25" rot="1 0 0 0" scale="" transform="1 0 0 -3 0 1 0 -43 0 0 1 3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 0.75" />
                            <Vertex pos="1 1 -0.25" />
                            <Vertex pos="1 -1 0.25" />
                            <Vertex pos="1 -1 -0.75" />
                            <Vertex pos="-1 1 0.75" />
                            <Vertex pos="-1 1 -0.25" />
                            <Vertex pos="-1 -1 0.25" />
                            <Vertex pos="-1 -1 -0.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3" texgens="0 1 0 256 0 0 -1 -576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -1" album="" material="bm_grid_blank3" texgens="0 -1 0 0 0 0.25 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank3" texgens="-1 0 0 -256 0 0 -1 -576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank3" texgens="1 0 0 768 0 0 -1 -576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.242536 0.970143 -0.485071" album="" material="bm_friction_mud" texgens="1 0 0 768 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.242536 -0.970143 -0.485071" album="" material="bm_grid_blank3" texgens="-1 0 0 -256 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="64" owner="0" type="0" pos="3 -39 3.5" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 -39 0 0 1 3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 0.5" />
                            <Vertex pos="1 3 -0.5" />
                            <Vertex pos="1 -3 0.5" />
                            <Vertex pos="1 -3 -0.5" />
                            <Vertex pos="-1 3 0.5" />
                            <Vertex pos="-1 3 -0.5" />
                            <Vertex pos="-1 -3 0.5" />
                            <Vertex pos="-1 -3 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3" texgens="0 1 0 768 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank3" texgens="-1 0 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank3" texgens="1 0 0 768 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile01_A" texgens="1 0 0 768 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 -256 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="65" owner="0" type="0" pos="-3 -39 3.5" rot="1 0 0 0" scale="" transform="1 0 0 -3 0 1 0 -39 0 0 1 3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 0.5" />
                            <Vertex pos="1 3 -0.5" />
                            <Vertex pos="1 -3 0.5" />
                            <Vertex pos="1 -3 -0.5" />
                            <Vertex pos="-1 3 0.5" />
                            <Vertex pos="-1 3 -0.5" />
                            <Vertex pos="-1 -3 0.5" />
                            <Vertex pos="-1 -3 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3" texgens="0 1 0 768 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank3" texgens="-1 0 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank3" texgens="1 0 0 768 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile01_A" texgens="1 0 0 768 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 -256 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="66" owner="0" type="0" pos="0 -38 3.5" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -38 0 0 1 3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.5" />
                            <Vertex pos="2 2 -0.5" />
                            <Vertex pos="2 -2 0.5" />
                            <Vertex pos="2 -2 -0.5" />
                            <Vertex pos="-2 2 0.5" />
                            <Vertex pos="-2 2 -0.5" />
                            <Vertex pos="-2 -2 0.5" />
                            <Vertex pos="-2 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 1024 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 -512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile01_A" texgens="1 0 0 512 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 0 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="67" owner="0" type="0" pos="0 -41 3.75" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -41 0 0 1 3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 0.25" />
                            <Vertex pos="2 1 -0.75" />
                            <Vertex pos="2 -1 0.75" />
                            <Vertex pos="2 -1 -0.25" />
                            <Vertex pos="-2 1 0.25" />
                            <Vertex pos="-2 1 -0.75" />
                            <Vertex pos="-2 -1 0.75" />
                            <Vertex pos="-2 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 0 0 -0.25 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 0 0 -0.25 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank3" texgens="-1 0 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank3" texgens="1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970143 -0.485071" album="" material="bm_friction_mud" texgens="1 0 0 512 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.242536 -0.970143 -0.485071" album="" material="bm_grid_blank3" texgens="-1 0 0 0 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="68" owner="0" type="0" pos="0 -43 4.5" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -43 0 0 1 4.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.999996 1.43051e-006" />
                            <Vertex pos="2 0.999996 -1" />
                            <Vertex pos="2 -1 1" />
                            <Vertex pos="2 -1 -9.53674e-007" />
                            <Vertex pos="-2 0.999996 1.43051e-006" />
                            <Vertex pos="-2 0.999996 -1" />
                            <Vertex pos="-2 -1 1" />
                            <Vertex pos="-2 -1 -9.53674e-007" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 0 0 -0.5 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 0 0 -0.5 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.999996" album="" material="bm_grid_blank3" texgens="-1 0 0 0 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank3" texgens="1 0 0 512 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.447214 0.894427 -0.447213" album="" material="bm_friction_mud" texgens="1 0 0 512 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.447214 -0.894427 -0.447215" album="" material="bm_grid_blank3" texgens="-1 0 0 0 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="69" owner="0" type="0" pos="0 -45 5.25" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -45 0 0 1 5.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 0.25" />
                            <Vertex pos="2 1 -0.75" />
                            <Vertex pos="2 -1 0.75" />
                            <Vertex pos="2 -1 -0.25" />
                            <Vertex pos="-2 1 0.25" />
                            <Vertex pos="-2 1 -0.75" />
                            <Vertex pos="-2 -1 0.75" />
                            <Vertex pos="-2 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 0 0 -0.25 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 0 0 -0.25 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank3" texgens="-1 0 0 0 0 0 -1 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank3" texgens="1 0 0 512 0 0 -1 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970143 -0.485071" album="" material="bm_friction_mud" texgens="1 0 0 512 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.242536 -0.970143 -0.485071" album="" material="bm_grid_blank3" texgens="-1 0 0 0 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="70" owner="0" type="0" pos="0 -48 5.5" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -48 0 0 1 5.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.5" />
                            <Vertex pos="2 2 -0.5" />
                            <Vertex pos="2 -2 0.5" />
                            <Vertex pos="2 -2 -0.5" />
                            <Vertex pos="-2 2 0.5" />
                            <Vertex pos="-2 2 -0.5" />
                            <Vertex pos="-2 -2 0.5" />
                            <Vertex pos="-2 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 1024 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 -512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile01_A" texgens="1 0 0 512 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 0 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="71" owner="0" type="0" pos="0 -38 -1.5" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -38 0 0 1 -1.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 4.5" />
                            <Vertex pos="4 2 -4.5" />
                            <Vertex pos="4 -2 4.5" />
                            <Vertex pos="4 -2 -4.5" />
                            <Vertex pos="-4 2 4.5" />
                            <Vertex pos="-4 2 -4.5" />
                            <Vertex pos="-4 -2 4.5" />
                            <Vertex pos="-4 -2 -4.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 -320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 -320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 -320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 -320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4.5" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4.5" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="72" owner="0" type="0" pos="3 -41 -1.5" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 -41 0 0 1 -1.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 4.5" />
                            <Vertex pos="1 1 -4.5" />
                            <Vertex pos="1 -1 4.5" />
                            <Vertex pos="1 -1 -4.5" />
                            <Vertex pos="-1 1 4.5" />
                            <Vertex pos="-1 1 -4.5" />
                            <Vertex pos="-1 -1 4.5" />
                            <Vertex pos="-1 -1 -4.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 384 0 0 -1 -320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 -128 0 0 -1 -320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 0 -1 -320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 384 0 0 -1 -320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4.5" album="" material="bm_grid_blank4" texgens="1 0 0 384 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="73" owner="0" type="0" pos="-3 -41 -1.5" rot="1 0 0 0" scale="" transform="1 0 0 -3 0 1 0 -41 0 0 1 -1.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 4.5" />
                            <Vertex pos="1 1 -4.5" />
                            <Vertex pos="1 -1 4.5" />
                            <Vertex pos="1 -1 -4.5" />
                            <Vertex pos="-1 1 4.5" />
                            <Vertex pos="-1 1 -4.5" />
                            <Vertex pos="-1 -1 4.5" />
                            <Vertex pos="-1 -1 -4.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 384 0 0 -1 -320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 -128 0 0 -1 -320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 0 -1 -320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 384 0 0 -1 -320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4.5" album="" material="bm_grid_blank4" texgens="1 0 0 384 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="74" owner="0" type="0" pos="0 -41 -1.25" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -41 0 0 1 -1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 4.25" />
                            <Vertex pos="2 1 -4.75" />
                            <Vertex pos="2 -1 4.75" />
                            <Vertex pos="2 -1 -4.75" />
                            <Vertex pos="-2 1 4.25" />
                            <Vertex pos="-2 1 -4.75" />
                            <Vertex pos="-2 -1 4.75" />
                            <Vertex pos="-2 -1 -4.75" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 384 0 0 -1 -352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 -128 0 0 -1 -352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 0 -1 -352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 512 0 0 -1 -352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970143 -4.36564" album="" material="bm_grid_blank4" texgens="1 0 0 512 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4.75" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="75" owner="0" type="0" pos="0 -43 -0.749999" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -43 0 0 1 -0.749999 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.999996 4.25" />
                            <Vertex pos="2 1 -5.25" />
                            <Vertex pos="2 -1 5.25" />
                            <Vertex pos="2 -1 -5.25" />
                            <Vertex pos="-2 0.999996 4.25" />
                            <Vertex pos="-2 1 -5.25" />
                            <Vertex pos="-2 -1 5.25" />
                            <Vertex pos="-2 -1 -5.25" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 384 0 0 -1 -416 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 -128 0 0 -1 -416 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 4.2037e-007 -0.999998" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 0 -1 -416 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 512 0 0 -1 -416 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.447214 0.894427 -4.24853" album="" material="bm_grid_blank4" texgens="1 0 0 512 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -5.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="76" owner="0" type="0" pos="0 -45 -0.5" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -45 0 0 1 -0.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 5" />
                            <Vertex pos="2 1 -5.5" />
                            <Vertex pos="2 -1 5.5" />
                            <Vertex pos="2 -1 -5.5" />
                            <Vertex pos="-2 1 5" />
                            <Vertex pos="-2 1 -5.5" />
                            <Vertex pos="-2 -1 5.5" />
                            <Vertex pos="-2 -1 -5.5" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 384 0 0 -1 -448 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 -128 0 0 -1 -448 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 0 -1 -448 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 512 0 0 -1 -448 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970143 -5.09325" album="" material="bm_grid_blank4" texgens="1 0 0 512 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -5.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="77" owner="0" type="0" pos="0 -48 -0.5" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -48 0 0 1 -0.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 5.5" />
                            <Vertex pos="2 2 -5.5" />
                            <Vertex pos="2 -2 5.5" />
                            <Vertex pos="2 -2 -5.5" />
                            <Vertex pos="-2 2 5.5" />
                            <Vertex pos="-2 2 -5.5" />
                            <Vertex pos="-2 -2 5.5" />
                            <Vertex pos="-2 -2 -5.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 -448 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 -448 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 0 -1 -448 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 512 0 0 -1 -448 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -5.5" album="" material="bm_grid_blank4" texgens="1 0 0 512 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -5.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="78" owner="0" type="0" pos="-3 -43 -1.5" rot="1 0 0 0" scale="" transform="1 0 0 -3 0 1 0 -43 0 0 1 -1.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 4.5" />
                            <Vertex pos="1 1 -4.5" />
                            <Vertex pos="1 -1 4" />
                            <Vertex pos="1 -1 -4.5" />
                            <Vertex pos="-1 1 4.5" />
                            <Vertex pos="-1 1 -4.5" />
                            <Vertex pos="-1 -1 4" />
                            <Vertex pos="-1 -1 -4.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 384 0 0 -1 -320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 -128 0 0 -1 -320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 0 -1 -320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 384 0 0 -1 -320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.242536 0.970143 -4.12311" album="" material="bm_grid_blank4" texgens="1 0 0 384 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="79" owner="0" type="0" pos="-3 -46 -1.75" rot="1 0 0 0" scale="" transform="1 0 0 -3 0 1 0 -46 0 0 1 -1.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 4.25" />
                            <Vertex pos="1 2 -4.25" />
                            <Vertex pos="1 -2 2.25" />
                            <Vertex pos="1 -2 -4.25" />
                            <Vertex pos="-1 2 4.25" />
                            <Vertex pos="-1 2 -4.25" />
                            <Vertex pos="-1 -2 2.25" />
                            <Vertex pos="-1 -2 -4.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 -288 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 -288 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 0 -1 -288 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 384 0 0 -1 -288 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.447214 0.894427 -2.90689" album="" material="bm_grid_blank4" texgens="1 0 0 384 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="80" owner="0" type="0" pos="-3 -49 -2.75" rot="1 0 0 0" scale="" transform="1 0 0 -3 0 1 0 -49 0 0 1 -2.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 3.25" />
                            <Vertex pos="1 1 -3.25" />
                            <Vertex pos="1 -1 2.75" />
                            <Vertex pos="1 -1 -3.25" />
                            <Vertex pos="-1 1 3.25" />
                            <Vertex pos="-1 1 -3.25" />
                            <Vertex pos="-1 -1 2.75" />
                            <Vertex pos="-1 -1 -3.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 384 0 0 -1 -160 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 -128 0 0 -1 -160 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 0 -1 -160 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 384 0 0 -1 -160 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.242536 0.970143 -2.91043" album="" material="bm_grid_blank4" texgens="1 0 0 384 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="81" owner="0" type="0" pos="3 -43 -1.5" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 -43 0 0 1 -1.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 4.5" />
                            <Vertex pos="1 1 -4.5" />
                            <Vertex pos="1 -1 4" />
                            <Vertex pos="1 -1 -4.5" />
                            <Vertex pos="-1 1 4.5" />
                            <Vertex pos="-1 1 -4.5" />
                            <Vertex pos="-1 -1 4" />
                            <Vertex pos="-1 -1 -4.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 384 0 0 -1 -320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 -128 0 0 -1 -320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 0 -1 -320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 384 0 0 -1 -320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.242536 0.970143 -4.12311" album="" material="bm_grid_blank4" texgens="1 0 0 384 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4.5" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="82" owner="0" type="0" pos="3 -46 -1.75" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 -46 0 0 1 -1.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 4.25" />
                            <Vertex pos="1 2 -4.25" />
                            <Vertex pos="1 -2 2.25" />
                            <Vertex pos="1 -2 -4.25" />
                            <Vertex pos="-1 2 4.25" />
                            <Vertex pos="-1 2 -4.25" />
                            <Vertex pos="-1 -2 2.25" />
                            <Vertex pos="-1 -2 -4.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 -288 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 -288 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 0 -1 -288 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 384 0 0 -1 -288 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.447214 0.894427 -2.90689" album="" material="bm_grid_blank4" texgens="1 0 0 384 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="83" owner="0" type="0" pos="3 -49 -2.75" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 -49 0 0 1 -2.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 3.25" />
                            <Vertex pos="1 1 -3.25" />
                            <Vertex pos="1 -1 2.75" />
                            <Vertex pos="1 -1 -3.25" />
                            <Vertex pos="-1 1 3.25" />
                            <Vertex pos="-1 1 -3.25" />
                            <Vertex pos="-1 -1 2.75" />
                            <Vertex pos="-1 -1 -3.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 384 0 0 -1 -160 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 -128 0 0 -1 -160 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 0 -1 -160 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 384 0 0 -1 -160 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.242536 0.970143 -2.91043" album="" material="bm_grid_blank4" texgens="1 0 0 384 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="84" owner="0" type="0" pos="-5 -45 -3.25" rot="1 0 0 0" scale="" transform="1 0 0 -5 0 1 0 -45 0 0 1 -3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 -0.250002" />
                            <Vertex pos="1 3 -2.75" />
                            <Vertex pos="1 -3 2.75" />
                            <Vertex pos="1 -3 -2.75" />
                            <Vertex pos="-1 3 -0.250002" />
                            <Vertex pos="-1 3 -2.75" />
                            <Vertex pos="-1 -3 2.75" />
                            <Vertex pos="-1 -3 -2.75" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 640 0 0 -1 -96 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 -384 0 0 -1 -96 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 896 0 0 -1 -96 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -640 0 0 -1 -96 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.447214 0.894427 -1.11803" album="" material="bm_grid_blank4" texgens="1 0 0 -640 0 -1 0 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2.75" album="" material="bm_grid_blank4" texgens="-1 0 0 896 0 -1 0 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="85" owner="0" type="0" pos="-5 -49 -3" rot="1 0 0 0" scale="" transform="1 0 0 -5 0 1 0 -49 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.999996 2.5" />
                            <Vertex pos="1 0.999996 -3" />
                            <Vertex pos="1 -0.999996 3" />
                            <Vertex pos="1 -0.999996 -3" />
                            <Vertex pos="-1 0.999996 2.5" />
                            <Vertex pos="-1 0.999996 -3" />
                            <Vertex pos="-1 -0.999996 3" />
                            <Vertex pos="-1 -0.999996 -3" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 896 0 0 -1 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 -640 0 0 -1 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.999996" album="" material="bm_grid_blank4" texgens="-1 0 0 896 0 0 -1 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.999996" album="" material="bm_grid_blank4" texgens="1 0 0 -640 0 0 -1 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242537 0.970142 -2.66789" album="" material="bm_grid_blank4" texgens="1 0 0 -640 0 -1 0 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 896 0 -1 0 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="86" owner="0" type="0" pos="0 -54 -3" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -54 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 4 3" />
                            <Vertex pos="6 4 -3" />
                            <Vertex pos="6 -4 3" />
                            <Vertex pos="6 -4 -3" />
                            <Vertex pos="-6 4 3" />
                            <Vertex pos="-6 4 -3" />
                            <Vertex pos="-6 -4 3" />
                            <Vertex pos="-6 -4 -3" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 0 -1 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 512 0 0 -1 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="" material="bm_grid_blank4" texgens="1 0 0 512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="87" owner="0" type="0" pos="5 -41 -4.75" rot="1 0 0 0" scale="" transform="1 0 0 5 0 1 0 -41 0 0 1 -4.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 0.75" />
                            <Vertex pos="1 1 -1.25" />
                            <Vertex pos="1 -1 1.25" />
                            <Vertex pos="1 -1 -1.25" />
                            <Vertex pos="-1 1 0.75" />
                            <Vertex pos="-1 1 -1.25" />
                            <Vertex pos="-1 -1 1.25" />
                            <Vertex pos="-1 -1 -1.25" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 896 0 0 -1 96 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 -640 0 0 -1 96 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 896 0 0 -1 96 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -640 0 0 -1 96 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970143 -0.970143" album="" material="bm_grid_blank4" texgens="1 0 0 -640 0 -1 0 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1.25" album="" material="bm_grid_blank4" texgens="-1 0 0 896 0 -1 0 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="88" owner="0" type="0" pos="5 -45 -3.25" rot="1 0 0 0" scale="" transform="1 0 0 5 0 1 0 -45 0 0 1 -3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 -0.250002" />
                            <Vertex pos="1 3 -2.75" />
                            <Vertex pos="1 -3 2.75" />
                            <Vertex pos="1 -3 -2.75" />
                            <Vertex pos="-1 3 -0.250002" />
                            <Vertex pos="-1 3 -2.75" />
                            <Vertex pos="-1 -3 2.75" />
                            <Vertex pos="-1 -3 -2.75" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 640 0 0 -1 -96 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 -384 0 0 -1 -96 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 896 0 0 -1 -96 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -640 0 0 -1 -96 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.447214 0.894427 -1.11803" album="" material="bm_grid_blank4" texgens="1 0 0 -640 0 -1 0 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2.75" album="" material="bm_grid_blank4" texgens="-1 0 0 896 0 -1 0 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="89" owner="0" type="0" pos="5 -49 -3" rot="1 0 0 0" scale="" transform="1 0 0 5 0 1 0 -49 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.999996 2.5" />
                            <Vertex pos="1 0.999996 -3" />
                            <Vertex pos="1 -0.999996 3" />
                            <Vertex pos="1 -0.999996 -3" />
                            <Vertex pos="-1 0.999996 2.5" />
                            <Vertex pos="-1 0.999996 -3" />
                            <Vertex pos="-1 -0.999996 3" />
                            <Vertex pos="-1 -0.999996 -3" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 896 0 0 -1 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 -640 0 0 -1 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.999996" album="" material="bm_grid_blank4" texgens="-1 0 0 896 0 0 -1 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.999996" album="" material="bm_grid_blank4" texgens="1 0 0 -640 0 0 -1 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242537 0.970142 -2.66789" album="" material="bm_grid_blank4" texgens="1 0 0 -640 0 -1 0 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 896 0 -1 0 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="90" owner="0" type="0" pos="-3 51 4.5" rot="1 0 0 0" scale="" transform="1 0 0 -3 0 1 0 51 0 0 1 4.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 0.5" />
                            <Vertex pos="1 3 -0.5" />
                            <Vertex pos="1 -3 0.5" />
                            <Vertex pos="1 -3 -0.5" />
                            <Vertex pos="-1 3 0.5" />
                            <Vertex pos="-1 3 -0.5" />
                            <Vertex pos="-1 -3 0.5" />
                            <Vertex pos="-1 -3 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3" texgens="0 1 0 1280 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3" texgens="0 -1 0 -768 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank3" texgens="-1 0 0 1280 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank3" texgens="1 0 0 -768 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_friction_ice" texgens="1 0 0 -768 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 1280 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="91" owner="0" type="0" pos="3 51 4.5" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 51 0 0 1 4.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 0.5" />
                            <Vertex pos="1 3 -0.5" />
                            <Vertex pos="1 -3 0.5" />
                            <Vertex pos="1 -3 -0.5" />
                            <Vertex pos="-1 3 0.5" />
                            <Vertex pos="-1 3 -0.5" />
                            <Vertex pos="-1 -3 0.5" />
                            <Vertex pos="-1 -3 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3" texgens="0 1 0 1280 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank3" texgens="0 -1 0 -768 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank3" texgens="-1 0 0 1280 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank3" texgens="1 0 0 -768 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_friction_ice" texgens="1 0 0 -768 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 1280 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="92" owner="0" type="0" pos="0 50 6.5" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 50 0 0 1 6.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.5" />
                            <Vertex pos="2 2 -0.5" />
                            <Vertex pos="2 -2 0.5" />
                            <Vertex pos="2 -2 -0.5" />
                            <Vertex pos="-2 2 0.5" />
                            <Vertex pos="-2 2 -0.5" />
                            <Vertex pos="-2 -2 0.5" />
                            <Vertex pos="-2 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 1536 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 -1024 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile06_A" texgens="1 0 0 0 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="93" owner="0" type="0" pos="0 53 5.5" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 53 0 0 1 5.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 -0.499995" />
                            <Vertex pos="2 1 -1.50001" />
                            <Vertex pos="2 -1 1.50001" />
                            <Vertex pos="2 -1 0.499995" />
                            <Vertex pos="-2 1 -0.499995" />
                            <Vertex pos="-2 1 -1.50001" />
                            <Vertex pos="-2 -1 1.50001" />
                            <Vertex pos="-2 -1 0.499995" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 0 0 -1 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 0 0 -1 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 0 -1 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank3" texgens="1 0 0 0 0 0 -1 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707108 0.707106 -0.353558" album="" material="bm_friction_ice" texgens="1 0 0 0 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.707108 -0.707106 -0.353558" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="94" owner="0" type="0" pos="0 57 4.5" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 57 0 0 1 4.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 0.5" />
                            <Vertex pos="2 1 -0.5" />
                            <Vertex pos="4 -1 0.5" />
                            <Vertex pos="4 -1 -0.5" />
                            <Vertex pos="-2 1 0.5" />
                            <Vertex pos="-2 1 -0.5" />
                            <Vertex pos="-4 -1 0.5" />
                            <Vertex pos="-4 -1 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 -2.12132" album="" material="bm_grid_blank3" texgens="0 1 0 1792 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 -2.12132" album="" material="bm_grid_blank3" texgens="0 -1 0 -1280 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank3" texgens="1 0 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_friction_ice" texgens="1 0 0 0 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="95" owner="0" type="0" pos="0 57 0" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 57 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 4" />
                            <Vertex pos="2 1 -6" />
                            <Vertex pos="3.99999 -1 4" />
                            <Vertex pos="3.99999 -1 -6" />
                            <Vertex pos="-2 1 4" />
                            <Vertex pos="-2 1 -6" />
                            <Vertex pos="-3.99999 -1 4" />
                            <Vertex pos="-3.99999 -1 -6" />
                        </Vertices>
                        <Face id="0" plane="0.707108 0.707105 0 -2.12132" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707108 0.707105 0 -2.12132" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -6" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="96" owner="0" type="0" pos="0 50 5" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 50 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 1" />
                            <Vertex pos="2 2 -1" />
                            <Vertex pos="2 -2 1" />
                            <Vertex pos="2 -2 -1" />
                            <Vertex pos="-2 2 1" />
                            <Vertex pos="-2 2 -1" />
                            <Vertex pos="-2 -2 1" />
                            <Vertex pos="-2 -2 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="97" owner="0" type="0" pos="0 53 4" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 53 0 0 1 4 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 2.38419e-006" />
                            <Vertex pos="2 1 -2" />
                            <Vertex pos="2 -1 2" />
                            <Vertex pos="2 -1 -2.86102e-006" />
                            <Vertex pos="-2 1 2.38419e-006" />
                            <Vertex pos="-2 1 -2" />
                            <Vertex pos="-2 -1 2" />
                            <Vertex pos="-2 -1 -2.86102e-006" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 -1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 -1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 -1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 -1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707106 0.707107 -0.707108" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.707106 -0.707107 -0.707108" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="98" owner="0" type="0" pos="-36 0 -7.5" rot="1 0 0 0" scale="" transform="1 0 0 -36 0 1 0 0 0 0 1 -7.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 6 0.5" />
                            <Vertex pos="4 6 -0.5" />
                            <Vertex pos="4 -6 0.5" />
                            <Vertex pos="4 -6 -0.5" />
                            <Vertex pos="-4 14 0.5" />
                            <Vertex pos="-4 14 -0.5" />
                            <Vertex pos="-4 -14 0.5" />
                            <Vertex pos="-4 -14 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank3" texgens="0 1 0 1024 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank3" texgens="0 -1 0 -512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -7.07107" album="" material="bm_grid_blank3" texgens="-1 0 0 1024 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -7.07107" album="" material="bm_grid_blank3" texgens="1 0 0 -512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 0 1 -0.5" album="" material="bm_tile05_A" texgens="1 0 0 -512 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 1024 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="99" owner="0" type="0" pos="-36 0 -9" rot="1 0 0 0" scale="" transform="1 0 0 -36 0 1 0 0 0 0 1 -9 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 6 1" />
                            <Vertex pos="4 6 -1" />
                            <Vertex pos="4 -6 1" />
                            <Vertex pos="4 -6 -1" />
                            <Vertex pos="-4 14 1" />
                            <Vertex pos="-4 14 -1" />
                            <Vertex pos="-4 -14 1" />
                            <Vertex pos="-4 -14 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 512 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -7.07107" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -7.07107" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 0 1 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="100" owner="0" type="0" pos="-46 0 -3.5" rot="1 0 0 0" scale="" transform="1 0 0 -46 0 1 0 0 0 0 1 -3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.5" />
                            <Vertex pos="2 2 -0.5" />
                            <Vertex pos="2 -2 0.5" />
                            <Vertex pos="2 -2 -0.5" />
                            <Vertex pos="-2 2 0.5" />
                            <Vertex pos="-2 2 -0.5" />
                            <Vertex pos="-2 -2 0.5" />
                            <Vertex pos="-2 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 512 0 0 -1 2176 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 0 0 0 -1 2176 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 1536 0 0 -1 2176 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 -1024 0 0 -1 2176 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile05_A" texgens="1 0 0 -1024 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 1536 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="101" owner="0" type="0" pos="-46 0 -7" rot="1 0 0 0" scale="" transform="1 0 0 -46 0 1 0 0 0 0 1 -7 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 3" />
                            <Vertex pos="2 2 -3" />
                            <Vertex pos="2 -2 3" />
                            <Vertex pos="2 -2 -3" />
                            <Vertex pos="-2 2 3" />
                            <Vertex pos="-2 2 -3" />
                            <Vertex pos="-2 -2 3" />
                            <Vertex pos="-2 -2 -3" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -512 0 0 -1 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -512 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="124" owner="0" type="0" pos="-42 10 -7.5" rot="1 0 0 0" scale="" transform="1 0 0 -42 0 1 0 10 0 0 1 -7.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 0.5" />
                            <Vertex pos="2 4 -0.5" />
                            <Vertex pos="2 -4 0.5" />
                            <Vertex pos="2 -4 -0.5" />
                            <Vertex pos="-2 4 0.5" />
                            <Vertex pos="-2 4 -0.5" />
                            <Vertex pos="-2 -4 0.5" />
                            <Vertex pos="-2 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 1024 0 0 -1 3200 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 -512 0 0 -1 3200 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 1536 0 0 -1 3200 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 -1024 0 0 -1 3200 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile05_A" texgens="1 0 0 -1024 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 1536 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="125" owner="0" type="0" pos="-42 10 -9" rot="1 0 0 0" scale="" transform="1 0 0 -42 0 1 0 10 0 0 1 -9 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 1" />
                            <Vertex pos="2 4 -1" />
                            <Vertex pos="2 -4 1" />
                            <Vertex pos="2 -4 -1" />
                            <Vertex pos="-2 4 1" />
                            <Vertex pos="-2 4 -1" />
                            <Vertex pos="-2 -4 1" />
                            <Vertex pos="-2 -4 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 512 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -512 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="126" owner="0" type="0" pos="-42 -10 -7.5" rot="1 0 0 0" scale="" transform="1 0 0 -42 0 1 0 -10 0 0 1 -7.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 0.5" />
                            <Vertex pos="2 4 -0.5" />
                            <Vertex pos="2 -4 0.5" />
                            <Vertex pos="2 -4 -0.5" />
                            <Vertex pos="-2 4 0.5" />
                            <Vertex pos="-2 4 -0.5" />
                            <Vertex pos="-2 -4 0.5" />
                            <Vertex pos="-2 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 1024 0 0 -1 3200 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 -512 0 0 -1 3200 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 1536 0 0 -1 3200 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 -1024 0 0 -1 3200 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile05_A" texgens="1 0 0 -1024 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 1536 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="127" owner="0" type="0" pos="-42 -10 -9" rot="1 0 0 0" scale="" transform="1 0 0 -42 0 1 0 -10 0 0 1 -9 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 1" />
                            <Vertex pos="2 4 -1" />
                            <Vertex pos="2 -4 1" />
                            <Vertex pos="2 -4 -1" />
                            <Vertex pos="-2 4 1" />
                            <Vertex pos="-2 4 -1" />
                            <Vertex pos="-2 -4 1" />
                            <Vertex pos="-2 -4 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 512 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -512 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="128" owner="17" type="999" pos="0 0 -11.5" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 0 0 0 1 -11.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 0.25" />
                            <Vertex pos="4 4 -0.25" />
                            <Vertex pos="4 -4 0.25" />
                            <Vertex pos="4 -4 -0.25" />
                            <Vertex pos="-4 4 0.25" />
                            <Vertex pos="-4 4 -0.25" />
                            <Vertex pos="-4 -4 0.25" />
                            <Vertex pos="-4 -4 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank3" texgens="0 1 0 -1792 0 0 -1 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank3" texgens="0 -1 0 -1792 0 0 -1 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 -1792 0 0 -1 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 -1792 0 0 -1 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile07_A" texgens="1 0 0 -512 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank3" texgens="-1 0 0 1024 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="129" owner="0" type="0" pos="-6 4.76837e-007 -11.5" rot="1 0 0 0" scale="" transform="1 0 0 -6 0 1 0 4.76837e-007 0 0 1 -11.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-2 6 0.5" />
                            <Vertex pos="-2 6 -0.5" />
                            <Vertex pos="-2 -6 0.5" />
                            <Vertex pos="-2 -6 -0.5" />
                            <Vertex pos="2 8 0.5" />
                            <Vertex pos="2 8 -0.5" />
                            <Vertex pos="2 -8 0.5" />
                            <Vertex pos="2 -8 -0.5" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="-0.447214 0.894427 0 -6.26099" album="" material="bm_grid_blank3" texgens="-1 0 0 1536 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="-0.447214 -0.894427 0 -6.26099" album="" material="bm_grid_blank3" texgens="1 0 0 -1024 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="3" plane="-0 0 1 -0.5" album="" material="bm_tile09_A" texgens="0 1 0 0.00012207 1 0 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="4" plane="0 -0 -1 -0.5" album="" material="bm_grid_blank3" texgens="0 -1 0 512 1 0 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="5" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 -512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="130" owner="0" type="0" pos="-2 7 -11.5" rot="1 0 0 0" scale="" transform="1 0 0 -2 0 1 0 7 0 0 1 -11.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 3 0.5" />
                            <Vertex pos="2 3 -0.5" />
                            <Vertex pos="-2 1 0.5" />
                            <Vertex pos="-2 1 -0.5" />
                            <Vertex pos="2 -3 0.5" />
                            <Vertex pos="2 -3 -0.5" />
                            <Vertex pos="-2 -3 0.5" />
                            <Vertex pos="-2 -3 -0.5" />
                        </Vertices>
                        <Face id="0" plane="-0.447214 0.894427 0 -1.78885" album="" material="bm_grid_blank3" texgens="-1 0 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 1792 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="-0 0 1 -0.5" album="" material="bm_tile09_A" texgens="0 1 0 1792 1 0 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="0 -1 0 -1280 1 0 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 -2304 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0 -1 0 -3" album="" material="bm_grid_blank3" texgens="-1 0 0 1536 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="131" owner="0" type="0" pos="-2 -7 -11.5" rot="1 0 0 0" scale="" transform="1 0 0 -2 0 1 0 -7 0 0 1 -11.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -3 0.5" />
                            <Vertex pos="2 -3 -0.5" />
                            <Vertex pos="-2 -0.999999 0.5" />
                            <Vertex pos="-2 -0.999999 -0.5" />
                            <Vertex pos="2 3 0.5" />
                            <Vertex pos="2 3 -0.5" />
                            <Vertex pos="-2 3 0.5" />
                            <Vertex pos="-2 3 -0.5" />
                        </Vertices>
                        <Face id="0" plane="-0.447214 -0.894427 -0 -1.78885" album="" material="bm_grid_blank3" texgens="1 0 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 -1792 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 0 1 -0.5" album="" material="bm_tile09_A" texgens="0 1 0 -1792 1 0 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="3" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="0 -1 0 2304 1 0 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="4" plane="-1 -0 -0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 1280 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="5" plane="0 1 -0 -3" album="" material="bm_grid_blank3" texgens="1 0 0 -1024 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="132" owner="0" type="0" pos="-6 4.76837e-007 -14" rot="1 0 0 0" scale="" transform="1 0 0 -6 0 1 0 4.76837e-007 0 0 1 -14 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-2 6 2" />
                            <Vertex pos="-2 6 -2" />
                            <Vertex pos="-2 -6 2" />
                            <Vertex pos="-2 -6 -2" />
                            <Vertex pos="2 8 2" />
                            <Vertex pos="2 8 -2" />
                            <Vertex pos="2 -8 2" />
                            <Vertex pos="2 -8 -2" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="-0.447214 0.894427 0 -6.26099" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="-0.447214 -0.894427 0 -6.26099" album="" material="bm_grid_blank4" texgens="1 0 0 -512 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="3" plane="-0 0 1 -2" album="" material="bm_grid_blank4" texgens="0 1 0 0 1 0 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="4" plane="0 -0 -1 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 256 1 0 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="5" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 -768 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="133" owner="0" type="0" pos="-2 7 -14" rot="1 0 0 0" scale="" transform="1 0 0 -2 0 1 0 7 0 0 1 -14 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 3 2" />
                            <Vertex pos="2 3 -2" />
                            <Vertex pos="-2 1 2" />
                            <Vertex pos="-2 1 -2" />
                            <Vertex pos="2 -3 2" />
                            <Vertex pos="2 -3 -2" />
                            <Vertex pos="-2 -3 2" />
                            <Vertex pos="-2 -3 -2" />
                        </Vertices>
                        <Face id="0" plane="-0.447214 0.894427 0 -1.78885" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 896 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="-0 0 1 -2" album="" material="bm_grid_blank4" texgens="0 1 0 896 1 0 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 0 -1 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 -640 1 0 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 -2304 0 0 -1 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="134" owner="0" type="0" pos="-2 -7 -14" rot="1 0 0 0" scale="" transform="1 0 0 -2 0 1 0 -7 0 0 1 -14 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -3 2" />
                            <Vertex pos="2 -3 -2" />
                            <Vertex pos="-2 -0.999999 2" />
                            <Vertex pos="-2 -0.999999 -2" />
                            <Vertex pos="2 3 2" />
                            <Vertex pos="2 3 -2" />
                            <Vertex pos="-2 3 2" />
                            <Vertex pos="-2 3 -2" />
                        </Vertices>
                        <Face id="0" plane="-0.447214 -0.894427 -0 -1.78885" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -896 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 0 1 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -896 1 0 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="3" plane="0 0 -1 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 1152 1 0 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="4" plane="-1 -0 -0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 1280 0 0 -1 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="5" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="135" owner="0" type="0" pos="4 7 -11.5" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 7 0 0 1 -11.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 3 0.500001" />
                            <Vertex pos="-4 3 -0.500001" />
                            <Vertex pos="4 -1 0.500001" />
                            <Vertex pos="4 -1 -0.500001" />
                            <Vertex pos="-4 -3 0.500001" />
                            <Vertex pos="-4 -3 -0.500001" />
                            <Vertex pos="4 -3 0.500001" />
                            <Vertex pos="4 -3 -0.500001" />
                        </Vertices>
                        <Face id="0" plane="0.447214 0.894427 0 -0.894427" album="" material="bm_grid_blank3" texgens="-1 0 0 1024 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank3" texgens="0 -1 0 -1280 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="1 -0 0 -4" album="" material="bm_grid_blank3" texgens="0 1 0 1792 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0 1 -0.500001" album="" material="bm_tile09_A" texgens="0 1 0 1792 1 0 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="-0 -0 -1 -0.500001" album="" material="bm_grid_blank3" texgens="0 -1 0 -1280 1 0 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 -1 0 -3" album="" material="bm_grid_blank3" texgens="-1 0 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="136" owner="0" type="0" pos="4 -7 -11.5" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 -7 0 0 1 -11.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 -3 0.499999" />
                            <Vertex pos="-4 -3 -0.499999" />
                            <Vertex pos="4 1 0.499999" />
                            <Vertex pos="4 1 -0.499999" />
                            <Vertex pos="-4 3 0.499999" />
                            <Vertex pos="-4 3 -0.499999" />
                            <Vertex pos="4 3 0.499999" />
                            <Vertex pos="4 3 -0.499999" />
                        </Vertices>
                        <Face id="0" plane="0.447214 -0.894427 0 -0.894427" album="" material="bm_grid_blank3" texgens="1 0 0 -512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="-1 -0 -0 -4" album="" material="bm_grid_blank3" texgens="0 -1 0 2304 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="1 0 0 -4" album="" material="bm_grid_blank3" texgens="0 1 0 -1792 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.499999" album="" material="bm_tile09_A" texgens="0 1 0 -1792 1 0 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="4" plane="0 0 -1 -0.499999" album="" material="bm_grid_blank3" texgens="0 -1 0 2304 1 0 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="5" plane="0 1 0 -3" album="" material="bm_grid_blank3" texgens="1 0 0 512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="137" owner="0" type="0" pos="6 0 -11.5" rot="1 0 0 0" scale="" transform="1 0 0 6 0 1 0 0 0 0 1 -11.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 0.5" />
                            <Vertex pos="2 4 -0.5" />
                            <Vertex pos="2 -4 0.5" />
                            <Vertex pos="2 -4 -0.5" />
                            <Vertex pos="-2 4 0.5" />
                            <Vertex pos="-2 4 -0.5" />
                            <Vertex pos="-2 -4 0.5" />
                            <Vertex pos="-2 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 -512 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-0 0 1 -0.5" album="" material="bm_tile09_A" texgens="0 1 0 0 1 0 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="3" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="0 -1 0 512 1 0 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="4" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 1024 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="5" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 1024 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="138" owner="21" type="999" pos="0 0 -12" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 0 0 0 1 -12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 0.25" />
                            <Vertex pos="3 3 -0.25" />
                            <Vertex pos="3 -3 0.25" />
                            <Vertex pos="3 -3 -0.25" />
                            <Vertex pos="-3 3 0.25" />
                            <Vertex pos="-3 3 -0.25" />
                            <Vertex pos="-3 -3 0.25" />
                            <Vertex pos="-3 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank3" texgens="0 1 0 -1280 0 0 -1 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank3" texgens="0 -1 0 -1280 0 0 -1 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank3" texgens="-1 0 0 -1280 0 0 -1 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank3" texgens="1 0 0 -1280 0 0 -1 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile06_A" texgens="1 0 0 -768 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank3" texgens="-1 0 0 1280 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="139" owner="25" type="999" pos="0 0 -12.5" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 0 0 0 1 -12.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.25" />
                            <Vertex pos="2 2 -0.25" />
                            <Vertex pos="2 -2 0.25" />
                            <Vertex pos="2 -2 -0.25" />
                            <Vertex pos="-2 2 0.25" />
                            <Vertex pos="-2 2 -0.25" />
                            <Vertex pos="-2 -2 0.25" />
                            <Vertex pos="-2 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 -768 0 0 -1 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 -1 0 -768 0 0 -1 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 -768 0 0 -1 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 -768 0 0 -1 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile05_A" texgens="1 0 0 -512 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank3" texgens="-1 0 0 1024 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="140" owner="0" type="0" pos="4 7 -14" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 7 0 0 1 -14 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 3 2" />
                            <Vertex pos="-4 3 -2" />
                            <Vertex pos="4 -1 2" />
                            <Vertex pos="4 -1 -2" />
                            <Vertex pos="-4 -3 2" />
                            <Vertex pos="-4 -3 -2" />
                            <Vertex pos="4 -3 2" />
                            <Vertex pos="4 -3 -2" />
                        </Vertices>
                        <Face id="0" plane="0.447214 0.894427 0 -0.894427" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 -640 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 896 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0 1 -2" album="" material="bm_grid_blank4" texgens="0 1 0 896 1 0 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="-0 -0 -1 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 -640 1 0 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 0 -1 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="141" owner="0" type="0" pos="4 -7 -14" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 -7 0 0 1 -14 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 -3 2" />
                            <Vertex pos="-4 -3 -2" />
                            <Vertex pos="4 1 2" />
                            <Vertex pos="4 1 -2" />
                            <Vertex pos="-4 3 2" />
                            <Vertex pos="-4 3 -2" />
                            <Vertex pos="4 3 2" />
                            <Vertex pos="4 3 -2" />
                        </Vertices>
                        <Face id="0" plane="0.447214 -0.894427 0 -0.894427" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="-1 -0 -0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 1152 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 -896 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -896 1 0 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="4" plane="0 0 -1 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 1152 1 0 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="5" plane="0 1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="142" owner="0" type="0" pos="6 0 -14" rot="1 0 0 0" scale="" transform="1 0 0 6 0 1 0 0 0 0 1 -14 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 2" />
                            <Vertex pos="2 4 -2" />
                            <Vertex pos="2 -4 2" />
                            <Vertex pos="2 -4 -2" />
                            <Vertex pos="-2 4 2" />
                            <Vertex pos="-2 4 -2" />
                            <Vertex pos="-2 -4 2" />
                            <Vertex pos="-2 -4 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-0 0 1 -2" album="" material="bm_grid_blank4" texgens="0 1 0 0 1 0 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="3" plane="0 0 -1 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 256 1 0 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="4" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="5" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 512 0 0 -1 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="143" owner="29" type="999" pos="0 0 -13" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 0 0 0 1 -13 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 1 0.25" />
                            <Vertex pos="-1 1 -0.25" />
                            <Vertex pos="-1 -1 0.25" />
                            <Vertex pos="-1 -1 -0.25" />
                            <Vertex pos="1 1 0.25" />
                            <Vertex pos="1 1 -0.25" />
                            <Vertex pos="1 -1 0.25" />
                            <Vertex pos="1 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -1" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 1 0 -1" album="" material="bm_grid_blank3" texgens="-1 0 0 -256 0 0 -1 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 -1 0 -1" album="" material="bm_grid_blank3" texgens="1 0 0 -256 0 0 -1 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="3" plane="0 0 1 -0.25" album="" material="bm_tile01_A" texgens="1 0 0 -256 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="4" plane="-0 -0 -1 -0.25" album="" material="bm_grid_blank3" texgens="-1 0 0 768 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="5" plane="1 -0 0 -1" album="" material="bm_grid_blank3" texgens="0 -1 0 -256 0 0 -1 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="144" owner="0" type="0" pos="3.5 0 -12" rot="1 0 0 0" scale="" transform="1 0 0 3.5 0 1 0 0 0 0 1 -12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 4 0.5" />
                            <Vertex pos="0.5 4 -0.5" />
                            <Vertex pos="0.5 -4 0.5" />
                            <Vertex pos="0.5 -4 -0.5" />
                            <Vertex pos="-0.5 4 0.5" />
                            <Vertex pos="-0.5 4 -0.5" />
                            <Vertex pos="-0.5 -4 0.5" />
                            <Vertex pos="-0.5 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_grid_blank3" texgens="0 1 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 -896 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-0 0 1 -0.5" album="" material="bm_tile09_A" texgens="0 1 0 -1536 1 0 0 256 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="3" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="0 -1 0 512 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="4" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 1408 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="5" plane="-1 0 0 -0.5" album="" material="bm_grid_blank3" texgens="0 1 0 1024 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="145" owner="0" type="0" pos="-3.5 0 -12" rot="1 0 0 0" scale="" transform="1 0 0 -3.5 0 1 0 0 0 0 1 -12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 4 0.5" />
                            <Vertex pos="0.5 4 -0.5" />
                            <Vertex pos="0.5 -4 0.5" />
                            <Vertex pos="0.5 -4 -0.5" />
                            <Vertex pos="-0.5 4 0.5" />
                            <Vertex pos="-0.5 4 -0.5" />
                            <Vertex pos="-0.5 -4 0.5" />
                            <Vertex pos="-0.5 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_grid_blank3" texgens="0 1 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 1 -0 -4" album="" material="bm_grid_blank3" texgens="-1 0 0 -896 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-0 0 1 -0.5" album="" material="bm_tile09_A" texgens="0 1 0 -1536 1 0 0 256 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="3" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="0 -1 0 512 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="4" plane="0 -1 0 -4" album="" material="bm_grid_blank3" texgens="1 0 0 1408 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="5" plane="-1 0 0 -0.5" album="" material="bm_grid_blank3" texgens="0 1 0 1024 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="146" owner="0" type="0" pos="0 -3.5 -12" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -3.5 0 0 1 -12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 0.5 0.5" />
                            <Vertex pos="3 0.5 -0.5" />
                            <Vertex pos="3 -0.5 0.5" />
                            <Vertex pos="3 -0.5 -0.5" />
                            <Vertex pos="-3 0.5 0.5" />
                            <Vertex pos="-3 0.5 -0.5" />
                            <Vertex pos="-3 -0.5 0.5" />
                            <Vertex pos="-3 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank3" texgens="0 1 0 -896 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 1 -0 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 -1536 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-0 0 1 -0.5" album="" material="bm_tile09_A" texgens="0 1 0 256 1 0 0 1536 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="3" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="0 -1 0 1408 1 0 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="4" plane="0 -1 0 -0.5" album="" material="bm_grid_blank3" texgens="1 0 0 2048 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="5" plane="-1 0 0 -3" album="" material="bm_grid_blank3" texgens="0 1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="147" owner="0" type="0" pos="0 3.5 -12" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 3.5 0 0 1 -12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 0.5 0.5" />
                            <Vertex pos="3 0.5 -0.5" />
                            <Vertex pos="3 -0.5 0.5" />
                            <Vertex pos="3 -0.5 -0.5" />
                            <Vertex pos="-3 0.5 0.5" />
                            <Vertex pos="-3 0.5 -0.5" />
                            <Vertex pos="-3 -0.5 0.5" />
                            <Vertex pos="-3 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank3" texgens="0 1 0 -896 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 1 -0 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 -1536 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-0 0 1 -0.5" album="" material="bm_tile09_A" texgens="0 1 0 256 1 0 0 1536 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="3" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="0 -1 0 1408 1 0 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="4" plane="0 -1 0 -0.5" album="" material="bm_grid_blank3" texgens="1 0 0 2048 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="5" plane="-1 0 0 -3" album="" material="bm_grid_blank3" texgens="0 1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="148" owner="0" type="0" pos="0 -2.5 -12.5" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -2.5 0 0 1 -12.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 0.5 0.5" />
                            <Vertex pos="3 0.5 -0.5" />
                            <Vertex pos="3 -0.5 0.5" />
                            <Vertex pos="3 -0.5 -0.5" />
                            <Vertex pos="-3 0.5 0.5" />
                            <Vertex pos="-3 0.5 -0.5" />
                            <Vertex pos="-3 -0.5 0.5" />
                            <Vertex pos="-3 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank3" texgens="0 1 0 -896 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 1 -0 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 -1536 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-0 0 1 -0.5" album="" material="bm_tile09_A" texgens="0 1 0 256 1 0 0 1536 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="3" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="0 -1 0 1408 1 0 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="4" plane="0 -1 0 -0.5" album="" material="bm_grid_blank3" texgens="1 0 0 2048 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="5" plane="-1 0 0 -3" album="" material="bm_grid_blank3" texgens="0 1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="149" owner="0" type="0" pos="0 2.5 -12.5" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 2.5 0 0 1 -12.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 0.5 0.5" />
                            <Vertex pos="3 0.5 -0.5" />
                            <Vertex pos="3 -0.5 0.5" />
                            <Vertex pos="3 -0.5 -0.5" />
                            <Vertex pos="-3 0.5 0.5" />
                            <Vertex pos="-3 0.5 -0.5" />
                            <Vertex pos="-3 -0.5 0.5" />
                            <Vertex pos="-3 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank3" texgens="0 1 0 -896 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 1 -0 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 -1536 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-0 0 1 -0.5" album="" material="bm_tile09_A" texgens="0 1 0 256 1 0 0 1536 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="3" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="0 -1 0 1408 1 0 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="4" plane="0 -1 0 -0.5" album="" material="bm_grid_blank3" texgens="1 0 0 2048 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="5" plane="-1 0 0 -3" album="" material="bm_grid_blank3" texgens="0 1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="150" owner="0" type="0" pos="2.5 0 -12.5" rot="1 0 0 0" scale="" transform="1 0 0 2.5 0 1 0 0 0 0 1 -12.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 2 0.5" />
                            <Vertex pos="0.5 2 -0.5" />
                            <Vertex pos="0.5 -2 0.5" />
                            <Vertex pos="0.5 -2 -0.5" />
                            <Vertex pos="-0.5 2 0.5" />
                            <Vertex pos="-0.5 2 -0.5" />
                            <Vertex pos="-0.5 -2 0.5" />
                            <Vertex pos="-0.5 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_grid_blank3" texgens="0 1 0 -1280 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 -2176 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-0 0 1 -0.5" album="" material="bm_tile09_A" texgens="0 1 0 -512 1 0 0 2816 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="3" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="0 -1 0 1792 1 0 0 1664 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="4" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 2688 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="5" plane="-1 0 0 -0.5" album="" material="bm_grid_blank3" texgens="0 1 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="151" owner="0" type="0" pos="-2.5 0 -12.5" rot="1 0 0 0" scale="" transform="1 0 0 -2.5 0 1 0 0 0 0 1 -12.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 2 0.5" />
                            <Vertex pos="0.5 2 -0.5" />
                            <Vertex pos="0.5 -2 0.5" />
                            <Vertex pos="0.5 -2 -0.5" />
                            <Vertex pos="-0.5 2 0.5" />
                            <Vertex pos="-0.5 2 -0.5" />
                            <Vertex pos="-0.5 -2 0.5" />
                            <Vertex pos="-0.5 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_grid_blank3" texgens="0 1 0 -1280 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 1 -0 -2" album="" material="bm_grid_blank3" texgens="-1 0 0 -2176 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-0 0 1 -0.5" album="" material="bm_tile09_A" texgens="0 1 0 -512 1 0 0 2816 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="3" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="0 -1 0 1792 1 0 0 1664 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="4" plane="0 -1 0 -2" album="" material="bm_grid_blank3" texgens="1 0 0 2688 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="5" plane="-1 0 0 -0.5" album="" material="bm_grid_blank3" texgens="0 1 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="152" owner="0" type="0" pos="0 -1.5 -13" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -1.5 0 0 1 -13 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.5 0.5" />
                            <Vertex pos="2 0.5 -0.5" />
                            <Vertex pos="2 -0.5 0.5" />
                            <Vertex pos="2 -0.5 -0.5" />
                            <Vertex pos="-2 0.5 0.5" />
                            <Vertex pos="-2 0.5 -0.5" />
                            <Vertex pos="-2 -0.5 0.5" />
                            <Vertex pos="-2 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 -896 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 1 -0 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 -1536 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-0 0 1 -0.5" album="" material="bm_tile09_A" texgens="0 1 0 256 1 0 0 1536 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="3" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="0 -1 0 1408 1 0 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="4" plane="0 -1 0 -0.5" album="" material="bm_grid_blank3" texgens="1 0 0 2048 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="5" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="153" owner="0" type="0" pos="0 1.5 -13" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 1.5 0 0 1 -13 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.5 0.5" />
                            <Vertex pos="2 0.5 -0.5" />
                            <Vertex pos="2 -0.5 0.5" />
                            <Vertex pos="2 -0.5 -0.5" />
                            <Vertex pos="-2 0.5 0.5" />
                            <Vertex pos="-2 0.5 -0.5" />
                            <Vertex pos="-2 -0.5 0.5" />
                            <Vertex pos="-2 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 -896 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 1 -0 -0.5" album="" material="bm_grid_blank3" texgens="-1 0 0 -1536 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-0 0 1 -0.5" album="" material="bm_tile09_A" texgens="0 1 0 256 1 0 0 1536 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="3" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="0 -1 0 1408 1 0 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="4" plane="0 -1 0 -0.5" album="" material="bm_grid_blank3" texgens="1 0 0 2048 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="5" plane="-1 0 0 -2" album="" material="bm_grid_blank3" texgens="0 1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="154" owner="0" type="0" pos="-1.5 0 -13" rot="1 0 0 0" scale="" transform="1 0 0 -1.5 0 1 0 0 0 0 1 -13 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 1 0.5" />
                            <Vertex pos="0.5 1 -0.5" />
                            <Vertex pos="0.5 -1 0.5" />
                            <Vertex pos="0.5 -1 -0.5" />
                            <Vertex pos="-0.5 1 0.5" />
                            <Vertex pos="-0.5 1 -0.5" />
                            <Vertex pos="-0.5 -1 0.5" />
                            <Vertex pos="-0.5 -1 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_grid_blank3" texgens="0 1 0 -768 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 1 -0 -1" album="" material="bm_grid_blank3" texgens="-1 0 0 -1152 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-0 0 1 -0.5" album="" material="bm_tile09_A" texgens="0 1 0 512 1 0 0 768 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="3" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="0 -1 0 1280 1 0 0 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="4" plane="0 -1 0 -1" album="" material="bm_grid_blank3" texgens="1 0 0 1664 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="5" plane="-1 0 0 -0.5" album="" material="bm_grid_blank3" texgens="0 1 0 256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="155" owner="0" type="0" pos="1.5 0 -13" rot="1 0 0 0" scale="" transform="1 0 0 1.5 0 1 0 0 0 0 1 -13 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 1 0.5" />
                            <Vertex pos="0.5 1 -0.5" />
                            <Vertex pos="0.5 -1 0.5" />
                            <Vertex pos="0.5 -1 -0.5" />
                            <Vertex pos="-0.5 1 0.5" />
                            <Vertex pos="-0.5 1 -0.5" />
                            <Vertex pos="-0.5 -1 0.5" />
                            <Vertex pos="-0.5 -1 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_grid_blank3" texgens="0 1 0 -768 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 1 -0 -1" album="" material="bm_grid_blank3" texgens="-1 0 0 -1152 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-0 0 1 -0.5" album="" material="bm_tile09_A" texgens="0 1 0 512 1 0 0 768 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="3" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="0 -1 0 1280 1 0 0 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="4" plane="0 -1 0 -1" album="" material="bm_grid_blank3" texgens="1 0 0 1664 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="5" plane="-1 0 0 -0.5" album="" material="bm_grid_blank3" texgens="0 1 0 256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="156" owner="0" type="0" pos="1.5 -2.5 -14.75" rot="1 0 0 0" scale="" transform="1 0 0 1.5 0 1 0 -2.5 0 0 1 -14.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.5 1.5 1.25" />
                            <Vertex pos="2.5 1.5 -1.25" />
                            <Vertex pos="2.5 -1.5 1.25" />
                            <Vertex pos="2.5 -1.5 -1.25" />
                            <Vertex pos="-2.5 1.5 1.25" />
                            <Vertex pos="-2.5 1.5 -1.25" />
                            <Vertex pos="-2.5 -1.5 1.25" />
                            <Vertex pos="-2.5 -1.5 -1.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2.5" album="" material="bm_grid_blank4" texgens="0 1 0 -320 0 0 -1 96 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 1 -0 -1.5" album="" material="bm_grid_blank4" texgens="-1 0 0 320 0 0 -1 -1440 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-0 0 1 -1.25" album="" material="bm_grid_blank4" texgens="0 1 0 -320 1 0 0 -64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="3" plane="0 0 -1 -1.25" album="" material="bm_grid_blank4" texgens="0 -1 0 576 1 0 0 -64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="4" plane="0 -1 0 -1.5" album="" material="bm_grid_blank4" texgens="1 0 0 -64 0 0 -1 -1440 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="5" plane="-1 0 0 -2.5" album="" material="bm_grid_blank4" texgens="0 1 0 192 0 0 -1 -1440 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="157" owner="0" type="0" pos="-2.5 -1.5 -14.75" rot="1 0 0 0" scale="" transform="1 0 0 -2.5 0 1 0 -1.5 0 0 1 -14.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.5 2.5 1.25" />
                            <Vertex pos="1.5 2.5 -1.25" />
                            <Vertex pos="1.5 -2.5 1.25" />
                            <Vertex pos="1.5 -2.5 -1.25" />
                            <Vertex pos="-1.5 2.5 1.25" />
                            <Vertex pos="-1.5 2.5 -1.25" />
                            <Vertex pos="-1.5 -2.5 1.25" />
                            <Vertex pos="-1.5 -2.5 -1.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.5" album="" material="bm_grid_blank4" texgens="0 1 0 -192 0 0 -1 96 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 1 -0 -2.5" album="" material="bm_grid_blank4" texgens="-1 0 0 320 0 0 -1 -1440 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-0 0 1 -1.25" album="" material="bm_grid_blank4" texgens="0 1 0 -192 1 0 0 -64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="3" plane="0 0 -1 -1.25" album="" material="bm_grid_blank4" texgens="0 -1 0 448 1 0 0 -64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="4" plane="0 -1 0 -2.5" album="" material="bm_grid_blank4" texgens="1 0 0 -64 0 0 -1 -1440 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="5" plane="-1 0 0 -1.5" album="" material="bm_grid_blank4" texgens="0 1 0 320 0 0 -1 -1440 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="158" owner="0" type="0" pos="2.5 1.5 -14.75" rot="1 0 0 0" scale="" transform="1 0 0 2.5 0 1 0 1.5 0 0 1 -14.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.5 2.5 1.25" />
                            <Vertex pos="1.5 2.5 -1.25" />
                            <Vertex pos="1.5 -2.5 1.25" />
                            <Vertex pos="1.5 -2.5 -1.25" />
                            <Vertex pos="-1.5 2.5 1.25" />
                            <Vertex pos="-1.5 2.5 -1.25" />
                            <Vertex pos="-1.5 -2.5 1.25" />
                            <Vertex pos="-1.5 -2.5 -1.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.5" album="" material="bm_grid_blank4" texgens="0 1 0 192 0 0 -1 96 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 1 -0 -2.5" album="" material="bm_grid_blank4" texgens="-1 0 0 192 0 0 -1 -1440 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-0 0 1 -1.25" album="" material="bm_grid_blank4" texgens="0 1 0 192 1 0 0 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="3" plane="0 0 -1 -1.25" album="" material="bm_grid_blank4" texgens="0 -1 0 64 1 0 0 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="4" plane="0 -1 0 -2.5" album="" material="bm_grid_blank4" texgens="1 0 0 64 0 0 -1 -1440 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="5" plane="-1 0 0 -1.5" album="" material="bm_grid_blank4" texgens="0 1 0 704 0 0 -1 -1440 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="159" owner="0" type="0" pos="-1.5 2.5 -14.75" rot="1 0 0 0" scale="" transform="1 0 0 -1.5 0 1 0 2.5 0 0 1 -14.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.5 1.5 1.25" />
                            <Vertex pos="2.5 1.5 -1.25" />
                            <Vertex pos="2.5 -1.5 1.25" />
                            <Vertex pos="2.5 -1.5 -1.25" />
                            <Vertex pos="-2.5 1.5 1.25" />
                            <Vertex pos="-2.5 1.5 -1.25" />
                            <Vertex pos="-2.5 -1.5 1.25" />
                            <Vertex pos="-2.5 -1.5 -1.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2.5" album="" material="bm_grid_blank4" texgens="0 1 0 320 0 0 -1 96 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 1 -0 -1.5" album="" material="bm_grid_blank4" texgens="-1 0 0 192 0 0 -1 -1440 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-0 0 1 -1.25" album="" material="bm_grid_blank4" texgens="0 1 0 320 1 0 0 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="3" plane="0 0 -1 -1.25" album="" material="bm_grid_blank4" texgens="0 -1 0 -64 1 0 0 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="4" plane="0 -1 0 -1.5" album="" material="bm_grid_blank4" texgens="1 0 0 64 0 0 -1 -1440 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="5" plane="-1 0 0 -2.5" album="" material="bm_grid_blank4" texgens="0 1 0 832 0 0 -1 -1440 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="160" owner="0" type="0" pos="0 0 -15.5" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 0 0 0 1 -15.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 0.5" />
                            <Vertex pos="1 1 -0.5" />
                            <Vertex pos="1 -1 0.5" />
                            <Vertex pos="1 -1 -0.5" />
                            <Vertex pos="-1 1 0.5" />
                            <Vertex pos="-1 1 -0.5" />
                            <Vertex pos="-1 -1 0.5" />
                            <Vertex pos="-1 -1 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3" texgens="0 1 0 -768 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 1 -0 -1" album="" material="bm_grid_blank3" texgens="-1 0 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-0 0 1 -0.5" album="" material="bm_friction_bounce_med" texgens="0 1 0 -768 1 0 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="3" plane="0 0 -1 -0.5" album="" material="bm_grid_blank3" texgens="0 -1 0 1280 1 0 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="4" plane="0 -1 0 -1" album="" material="bm_grid_blank3" texgens="1 0 0 768 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="5" plane="-1 0 0 -1" album="" material="bm_grid_blank3" texgens="0 1 0 256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="161" owner="1" type="999" pos="46 2.98023e-008 5.5" rot="1 0 0 0" scale="" transform="1 0 0 46 0 1 0 2.98023e-008 0 0 1 5.5 0 0 0 1" group="-1" locked="0" nextFaceID="35" nextVertexID="49">
                        <Vertices>
                            <Vertex pos="0.482963 0.129409 -0.5" />
                            <Vertex pos="0.482964 0.129409 -0.25" />
                            <Vertex pos="0.5 -2.98023e-008 -0.5" />
                            <Vertex pos="0.5 -2.98023e-008 -0.25" />
                            <Vertex pos="0.433013 0.25 -0.5" />
                            <Vertex pos="0.433014 0.25 -0.25" />
                            <Vertex pos="0.353553 0.353553 -0.5" />
                            <Vertex pos="0.353554 0.353553 -0.25" />
                            <Vertex pos="0.249999 0.433013 -0.5" />
                            <Vertex pos="0.25 0.433013 -0.25" />
                            <Vertex pos="0.129408 0.482963 -0.5" />
                            <Vertex pos="0.129406 0.482963 -0.25" />
                            <Vertex pos="-1.56844e-006 0.5 -0.5" />
                            <Vertex pos="0 0.5 -0.25" />
                            <Vertex pos="-0.129412 0.482962 -0.5" />
                            <Vertex pos="-0.129414 0.482962 -0.25" />
                            <Vertex pos="-0.249998 0.433014 -0.5" />
                            <Vertex pos="-0.249996 0.433014 -0.25" />
                            <Vertex pos="-0.353552 0.353555 -0.5" />
                            <Vertex pos="-0.353554 0.353555 -0.25" />
                            <Vertex pos="-0.433012 0.250002 -0.5" />
                            <Vertex pos="-0.433014 0.250002 -0.25" />
                            <Vertex pos="-0.482962 0.129411 -0.5" />
                            <Vertex pos="-0.482964 0.129411 -0.25" />
                            <Vertex pos="-0.5 5.40998e-007 -0.5" />
                            <Vertex pos="-0.5 5.40998e-007 -0.25" />
                            <Vertex pos="-0.482963 -0.129408 -0.5" />
                            <Vertex pos="-0.482964 -0.129408 -0.25" />
                            <Vertex pos="-0.433013 -0.249999 -0.5" />
                            <Vertex pos="-0.433014 -0.249999 -0.25" />
                            <Vertex pos="-0.353554 -0.353553 -0.5" />
                            <Vertex pos="-0.353554 -0.353553 -0.25" />
                            <Vertex pos="-0.25 -0.433013 -0.5" />
                            <Vertex pos="-0.25 -0.433013 -0.25" />
                            <Vertex pos="-0.129409 -0.482963 -0.5" />
                            <Vertex pos="-0.12941 -0.482963 -0.25" />
                            <Vertex pos="4.86453e-007 -0.5 -0.5" />
                            <Vertex pos="0 -0.5 -0.25" />
                            <Vertex pos="0.12941 -0.482963 -0.5" />
                            <Vertex pos="0.12941 -0.482963 -0.25" />
                            <Vertex pos="0.250001 -0.433012 -0.5" />
                            <Vertex pos="0.25 -0.433012 -0.25" />
                            <Vertex pos="0.353554 -0.353552 -0.5" />
                            <Vertex pos="0.353554 -0.353552 -0.25" />
                            <Vertex pos="0.433014 -0.249998 -0.5" />
                            <Vertex pos="0.433014 -0.249998 -0.25" />
                            <Vertex pos="0.482963 -0.129408 -0.5" />
                            <Vertex pos="0.482964 -0.129408 -0.25" />
                        </Vertices>
                        <Face id="8" plane="0.991446 0.130518 -4.01844e-006 -0.495724" album="Blasted" material="button_bm" texgens="-0.130526 0.991445 0 2.08842 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="9" plane="0.923881 0.382681 -3.7446e-006 -0.495724" album="Blasted" material="button_bm" texgens="-0.382681 0.923881 0 6.26522 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="10" plane="0.79335 0.608766 -3.21554e-006 -0.495724" album="Blasted" material="button_bm" texgens="-0.608766 0.79335 0 10.4422 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="11" plane="0.608763 0.793353 -2.4311e-006 -0.495723" album="Blasted" material="button_bm" texgens="-0.793353 0.608763 0 14.6189 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="12" plane="0.382681 0.923881 3.05648e-006 -0.495721" album="Blasted" material="button_bm" texgens="-0.923881 0.382681 0 18.7958 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="13" plane="0.130526 0.991445 -8.18886e-007 -0.495723" album="Blasted" material="button_bm" texgens="-0.991445 0.130525 0 22.9726 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="14" plane="-0.130532 0.991444 -1.05034e-006 -0.495723" album="Blasted" material="button_bm" texgens="-0.991444 -0.130532 0 27.1495 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="15" plane="-0.382681 0.92388 3.05648e-006 -0.495721" album="Blasted" material="button_bm" texgens="-0.923881 -0.382681 0 31.3262 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 17 16 14 15" />
                        </Face>
                        <Face id="16" plane="-0.608758 0.793356 -4.86216e-006 -0.495725" album="Blasted" material="button_bm" texgens="-0.793356 -0.608758 0 35.5031 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 19 18 16 17" />
                        </Face>
                        <Face id="17" plane="-0.79335 0.608766 -6.3365e-006 -0.495726" album="Blasted" material="button_bm" texgens="-0.608766 -0.79335 0 39.6797 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 21 20 18 19" />
                        </Face>
                        <Face id="18" plane="-0.923881 0.382681 -7.37905e-006 -0.495726" album="Blasted" material="button_bm" texgens="-0.382681 -0.923881 0 43.8569 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 23 22 20 21" />
                        </Face>
                        <Face id="19" plane="-0.991444 0.130532 0 -0.495722" album="Blasted" material="button_bm" texgens="-0.130533 -0.991444 0 48.0336 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 25 24 22 23" />
                        </Face>
                        <Face id="20" plane="-0.991445 -0.130527 -4.01844e-006 -0.495724" album="Blasted" material="button_bm" texgens="0.130525 -0.991445 0 52.2104 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 27 26 24 25" />
                        </Face>
                        <Face id="21" plane="-0.923881 -0.382681 -3.7446e-006 -0.495724" album="Blasted" material="button_bm" texgens="0.382683 -0.92388 0 56.3873 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 29 28 26 27" />
                        </Face>
                        <Face id="22" plane="-0.793356 -0.608758 0 -0.495722" album="Blasted" material="button_bm" texgens="0.608758 -0.793356 0 60.5642 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 31 30 28 29" />
                        </Face>
                        <Face id="23" plane="-0.608762 -0.793353 0 -0.495723" album="Blasted" material="button_bm" texgens="0.793353 -0.608762 0 64.7409 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 33 32 30 31" />
                        </Face>
                        <Face id="24" plane="-0.382681 -0.923881 -1.52824e-006 -0.495723" album="Blasted" material="button_bm" texgens="0.923881 -0.382681 0 68.9179 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 35 34 32 33" />
                        </Face>
                        <Face id="25" plane="-0.130526 -0.991445 -2.53978e-007 -0.495723" album="Blasted" material="button_bm" texgens="0.991445 -0.130526 0 73.0948 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 37 36 34 35" />
                        </Face>
                        <Face id="26" plane="0.130526 -0.991445 0 -0.495723" album="Blasted" material="button_bm" texgens="0.991445 0.130526 0 77.2714 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 39 38 36 37" />
                        </Face>
                        <Face id="27" plane="0.382687 -0.923878 1.55107e-006 -0.495722" album="Blasted" material="button_bm" texgens="0.923878 0.382687 0 81.4485 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 41 40 38 39" />
                        </Face>
                        <Face id="28" plane="0.608766 -0.79335 0 -0.495722" album="Blasted" material="button_bm" texgens="0.79335 0.608766 0 85.6251 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 43 42 40 41" />
                        </Face>
                        <Face id="29" plane="0.793353 -0.608762 0 -0.495722" album="Blasted" material="button_bm" texgens="0.608762 0.793353 0 89.802 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 45 44 42 43" />
                        </Face>
                        <Face id="30" plane="0.923882 -0.382677 -3.7446e-006 -0.495724" album="Blasted" material="button_bm" texgens="0.382677 0.923882 0 93.979 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 47 46 44 45" />
                        </Face>
                        <Face id="31" plane="0.991446 -0.130519 0 -0.495723" album="Blasted" material="button_bm" texgens="0.130527 0.991445 0 98.1556 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 47 3 2 46" />
                        </Face>
                        <Face id="32" plane="-0 0 -1 -0.5" album="Blasted" material="button_bm" texgens="-1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 46 2 0 4 6 8 10 12 14 16 18 20 22 24 26 28 30 32 34 36 38 40 42 44" />
                        </Face>
                        <Face id="33" plane="0 -0 1 0.25" album="Blasted" material="button_bm" texgens="1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 47 45 43 41 39 37 35 33 31 29 27 25 23 21 19 17 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="162" owner="5" type="999" pos="0 50 7.5" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 50 0 0 1 7.5 0 0 0 1" group="-1" locked="0" nextFaceID="35" nextVertexID="49">
                        <Vertices>
                            <Vertex pos="0.482963 0.129409 -0.5" />
                            <Vertex pos="0.482964 0.129409 -0.25" />
                            <Vertex pos="0.5 -2.98023e-008 -0.5" />
                            <Vertex pos="0.5 -2.98023e-008 -0.25" />
                            <Vertex pos="0.433013 0.25 -0.5" />
                            <Vertex pos="0.433014 0.25 -0.25" />
                            <Vertex pos="0.353553 0.353553 -0.5" />
                            <Vertex pos="0.353554 0.353553 -0.25" />
                            <Vertex pos="0.249999 0.433013 -0.5" />
                            <Vertex pos="0.25 0.433013 -0.25" />
                            <Vertex pos="0.129408 0.482963 -0.5" />
                            <Vertex pos="0.129406 0.482963 -0.25" />
                            <Vertex pos="-1.56844e-006 0.5 -0.5" />
                            <Vertex pos="0 0.5 -0.25" />
                            <Vertex pos="-0.129412 0.482962 -0.5" />
                            <Vertex pos="-0.129414 0.482962 -0.25" />
                            <Vertex pos="-0.249998 0.433014 -0.5" />
                            <Vertex pos="-0.249996 0.433014 -0.25" />
                            <Vertex pos="-0.353552 0.353555 -0.5" />
                            <Vertex pos="-0.353554 0.353555 -0.25" />
                            <Vertex pos="-0.433012 0.250002 -0.5" />
                            <Vertex pos="-0.433014 0.250002 -0.25" />
                            <Vertex pos="-0.482962 0.129411 -0.5" />
                            <Vertex pos="-0.482964 0.129411 -0.25" />
                            <Vertex pos="-0.5 5.40998e-007 -0.5" />
                            <Vertex pos="-0.5 5.40998e-007 -0.25" />
                            <Vertex pos="-0.482963 -0.129408 -0.5" />
                            <Vertex pos="-0.482964 -0.129408 -0.25" />
                            <Vertex pos="-0.433013 -0.249999 -0.5" />
                            <Vertex pos="-0.433014 -0.249999 -0.25" />
                            <Vertex pos="-0.353554 -0.353553 -0.5" />
                            <Vertex pos="-0.353554 -0.353553 -0.25" />
                            <Vertex pos="-0.25 -0.433013 -0.5" />
                            <Vertex pos="-0.25 -0.433013 -0.25" />
                            <Vertex pos="-0.129409 -0.482963 -0.5" />
                            <Vertex pos="-0.12941 -0.482963 -0.25" />
                            <Vertex pos="4.86453e-007 -0.5 -0.5" />
                            <Vertex pos="0 -0.5 -0.25" />
                            <Vertex pos="0.12941 -0.482963 -0.5" />
                            <Vertex pos="0.12941 -0.482963 -0.25" />
                            <Vertex pos="0.250001 -0.433012 -0.5" />
                            <Vertex pos="0.25 -0.433012 -0.25" />
                            <Vertex pos="0.353554 -0.353552 -0.5" />
                            <Vertex pos="0.353554 -0.353552 -0.25" />
                            <Vertex pos="0.433014 -0.249998 -0.5" />
                            <Vertex pos="0.433014 -0.249998 -0.25" />
                            <Vertex pos="0.482963 -0.129408 -0.5" />
                            <Vertex pos="0.482964 -0.129408 -0.25" />
                        </Vertices>
                        <Face id="8" plane="0.991446 0.130518 -4.01844e-006 -0.495724" album="Blasted" material="button_bm" texgens="-0.130526 0.991445 0 2.08842 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="9" plane="0.923881 0.382681 -3.7446e-006 -0.495724" album="Blasted" material="button_bm" texgens="-0.382681 0.923881 0 6.26522 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="10" plane="0.79335 0.608766 -3.21554e-006 -0.495724" album="Blasted" material="button_bm" texgens="-0.608766 0.79335 0 10.4422 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="11" plane="0.608763 0.793353 -2.4311e-006 -0.495723" album="Blasted" material="button_bm" texgens="-0.793353 0.608763 0 14.6189 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="12" plane="0.382681 0.923881 3.05648e-006 -0.495721" album="Blasted" material="button_bm" texgens="-0.923881 0.382681 0 18.7958 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="13" plane="0.130526 0.991445 -8.18886e-007 -0.495723" album="Blasted" material="button_bm" texgens="-0.991445 0.130525 0 22.9726 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="14" plane="-0.130532 0.991444 -1.05034e-006 -0.495723" album="Blasted" material="button_bm" texgens="-0.991444 -0.130532 0 27.1495 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="15" plane="-0.382681 0.92388 3.05648e-006 -0.495721" album="Blasted" material="button_bm" texgens="-0.923881 -0.382681 0 31.3262 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 17 16 14 15" />
                        </Face>
                        <Face id="16" plane="-0.608758 0.793356 -4.86216e-006 -0.495725" album="Blasted" material="button_bm" texgens="-0.793356 -0.608758 0 35.5031 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 19 18 16 17" />
                        </Face>
                        <Face id="17" plane="-0.79335 0.608766 -6.3365e-006 -0.495726" album="Blasted" material="button_bm" texgens="-0.608766 -0.79335 0 39.6797 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 21 20 18 19" />
                        </Face>
                        <Face id="18" plane="-0.923881 0.382681 -7.37905e-006 -0.495726" album="Blasted" material="button_bm" texgens="-0.382681 -0.923881 0 43.8569 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 23 22 20 21" />
                        </Face>
                        <Face id="19" plane="-0.991444 0.130532 0 -0.495722" album="Blasted" material="button_bm" texgens="-0.130533 -0.991444 0 48.0336 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 25 24 22 23" />
                        </Face>
                        <Face id="20" plane="-0.991445 -0.130527 -4.01844e-006 -0.495724" album="Blasted" material="button_bm" texgens="0.130525 -0.991445 0 52.2104 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 27 26 24 25" />
                        </Face>
                        <Face id="21" plane="-0.923881 -0.382681 -3.7446e-006 -0.495724" album="Blasted" material="button_bm" texgens="0.382683 -0.92388 0 56.3873 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 29 28 26 27" />
                        </Face>
                        <Face id="22" plane="-0.793356 -0.608758 0 -0.495722" album="Blasted" material="button_bm" texgens="0.608758 -0.793356 0 60.5642 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 31 30 28 29" />
                        </Face>
                        <Face id="23" plane="-0.608762 -0.793353 0 -0.495723" album="Blasted" material="button_bm" texgens="0.793353 -0.608762 0 64.7409 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 33 32 30 31" />
                        </Face>
                        <Face id="24" plane="-0.382681 -0.923881 -1.52824e-006 -0.495723" album="Blasted" material="button_bm" texgens="0.923881 -0.382681 0 68.9179 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 35 34 32 33" />
                        </Face>
                        <Face id="25" plane="-0.130526 -0.991445 -2.53978e-007 -0.495723" album="Blasted" material="button_bm" texgens="0.991445 -0.130526 0 73.0948 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 37 36 34 35" />
                        </Face>
                        <Face id="26" plane="0.130526 -0.991445 0 -0.495723" album="Blasted" material="button_bm" texgens="0.991445 0.130526 0 77.2714 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 39 38 36 37" />
                        </Face>
                        <Face id="27" plane="0.382687 -0.923878 1.55107e-006 -0.495722" album="Blasted" material="button_bm" texgens="0.923878 0.382687 0 81.4485 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 41 40 38 39" />
                        </Face>
                        <Face id="28" plane="0.608766 -0.79335 0 -0.495722" album="Blasted" material="button_bm" texgens="0.79335 0.608766 0 85.6251 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 43 42 40 41" />
                        </Face>
                        <Face id="29" plane="0.793353 -0.608762 0 -0.495722" album="Blasted" material="button_bm" texgens="0.608762 0.793353 0 89.802 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 45 44 42 43" />
                        </Face>
                        <Face id="30" plane="0.923882 -0.382677 -3.7446e-006 -0.495724" album="Blasted" material="button_bm" texgens="0.382677 0.923882 0 93.979 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 47 46 44 45" />
                        </Face>
                        <Face id="31" plane="0.991446 -0.130519 0 -0.495723" album="Blasted" material="button_bm" texgens="0.130527 0.991445 0 98.1556 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 47 3 2 46" />
                        </Face>
                        <Face id="32" plane="-0 0 -1 -0.5" album="Blasted" material="button_bm" texgens="-1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 46 2 0 4 6 8 10 12 14 16 18 20 22 24 26 28 30 32 34 36 38 40 42 44" />
                        </Face>
                        <Face id="33" plane="0 -0 1 0.25" album="Blasted" material="button_bm" texgens="1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 47 45 43 41 39 37 35 33 31 29 27 25 23 21 19 17 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="163" owner="13" type="999" pos="0 -48 6.5" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -48 0 0 1 6.5 0 0 0 1" group="-1" locked="0" nextFaceID="35" nextVertexID="49">
                        <Vertices>
                            <Vertex pos="0.482963 0.129409 -0.5" />
                            <Vertex pos="0.482964 0.129409 -0.25" />
                            <Vertex pos="0.5 -2.98023e-008 -0.5" />
                            <Vertex pos="0.5 -2.98023e-008 -0.25" />
                            <Vertex pos="0.433013 0.25 -0.5" />
                            <Vertex pos="0.433014 0.25 -0.25" />
                            <Vertex pos="0.353553 0.353553 -0.5" />
                            <Vertex pos="0.353554 0.353553 -0.25" />
                            <Vertex pos="0.249999 0.433013 -0.5" />
                            <Vertex pos="0.25 0.433013 -0.25" />
                            <Vertex pos="0.129408 0.482963 -0.5" />
                            <Vertex pos="0.129406 0.482963 -0.25" />
                            <Vertex pos="-1.56844e-006 0.5 -0.5" />
                            <Vertex pos="0 0.5 -0.25" />
                            <Vertex pos="-0.129412 0.482962 -0.5" />
                            <Vertex pos="-0.129414 0.482962 -0.25" />
                            <Vertex pos="-0.249998 0.433014 -0.5" />
                            <Vertex pos="-0.249996 0.433014 -0.25" />
                            <Vertex pos="-0.353552 0.353555 -0.5" />
                            <Vertex pos="-0.353554 0.353555 -0.25" />
                            <Vertex pos="-0.433012 0.250002 -0.5" />
                            <Vertex pos="-0.433014 0.250002 -0.25" />
                            <Vertex pos="-0.482962 0.129411 -0.5" />
                            <Vertex pos="-0.482964 0.129411 -0.25" />
                            <Vertex pos="-0.5 5.40998e-007 -0.5" />
                            <Vertex pos="-0.5 5.40998e-007 -0.25" />
                            <Vertex pos="-0.482963 -0.129408 -0.5" />
                            <Vertex pos="-0.482964 -0.129408 -0.25" />
                            <Vertex pos="-0.433013 -0.249999 -0.5" />
                            <Vertex pos="-0.433014 -0.249999 -0.25" />
                            <Vertex pos="-0.353554 -0.353553 -0.5" />
                            <Vertex pos="-0.353554 -0.353553 -0.25" />
                            <Vertex pos="-0.25 -0.433013 -0.5" />
                            <Vertex pos="-0.25 -0.433013 -0.25" />
                            <Vertex pos="-0.129409 -0.482963 -0.5" />
                            <Vertex pos="-0.12941 -0.482963 -0.25" />
                            <Vertex pos="4.86453e-007 -0.5 -0.5" />
                            <Vertex pos="0 -0.5 -0.25" />
                            <Vertex pos="0.12941 -0.482963 -0.5" />
                            <Vertex pos="0.12941 -0.482963 -0.25" />
                            <Vertex pos="0.250001 -0.433012 -0.5" />
                            <Vertex pos="0.25 -0.433012 -0.25" />
                            <Vertex pos="0.353554 -0.353552 -0.5" />
                            <Vertex pos="0.353554 -0.353552 -0.25" />
                            <Vertex pos="0.433014 -0.249998 -0.5" />
                            <Vertex pos="0.433014 -0.249998 -0.25" />
                            <Vertex pos="0.482963 -0.129408 -0.5" />
                            <Vertex pos="0.482964 -0.129408 -0.25" />
                        </Vertices>
                        <Face id="8" plane="0.991446 0.130518 -4.01844e-006 -0.495724" album="Blasted" material="button_bm" texgens="-0.130526 0.991445 0 2.08842 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="9" plane="0.923881 0.382681 -3.7446e-006 -0.495724" album="Blasted" material="button_bm" texgens="-0.382681 0.923881 0 6.26522 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="10" plane="0.79335 0.608766 -3.21554e-006 -0.495724" album="Blasted" material="button_bm" texgens="-0.608766 0.79335 0 10.4422 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="11" plane="0.608763 0.793353 -2.4311e-006 -0.495723" album="Blasted" material="button_bm" texgens="-0.793353 0.608763 0 14.6189 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="12" plane="0.382681 0.923881 3.05648e-006 -0.495721" album="Blasted" material="button_bm" texgens="-0.923881 0.382681 0 18.7958 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="13" plane="0.130526 0.991445 -8.18886e-007 -0.495723" album="Blasted" material="button_bm" texgens="-0.991445 0.130525 0 22.9726 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="14" plane="-0.130532 0.991444 -1.05034e-006 -0.495723" album="Blasted" material="button_bm" texgens="-0.991444 -0.130532 0 27.1495 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="15" plane="-0.382681 0.92388 3.05648e-006 -0.495721" album="Blasted" material="button_bm" texgens="-0.923881 -0.382681 0 31.3262 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 17 16 14 15" />
                        </Face>
                        <Face id="16" plane="-0.608758 0.793356 -4.86216e-006 -0.495725" album="Blasted" material="button_bm" texgens="-0.793356 -0.608758 0 35.5031 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 19 18 16 17" />
                        </Face>
                        <Face id="17" plane="-0.79335 0.608766 -6.3365e-006 -0.495726" album="Blasted" material="button_bm" texgens="-0.608766 -0.79335 0 39.6797 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 21 20 18 19" />
                        </Face>
                        <Face id="18" plane="-0.923881 0.382681 -7.37905e-006 -0.495726" album="Blasted" material="button_bm" texgens="-0.382681 -0.923881 0 43.8569 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 23 22 20 21" />
                        </Face>
                        <Face id="19" plane="-0.991444 0.130532 0 -0.495722" album="Blasted" material="button_bm" texgens="-0.130533 -0.991444 0 48.0336 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 25 24 22 23" />
                        </Face>
                        <Face id="20" plane="-0.991445 -0.130527 -4.01844e-006 -0.495724" album="Blasted" material="button_bm" texgens="0.130525 -0.991445 0 52.2104 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 27 26 24 25" />
                        </Face>
                        <Face id="21" plane="-0.923881 -0.382681 -3.7446e-006 -0.495724" album="Blasted" material="button_bm" texgens="0.382683 -0.92388 0 56.3873 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 29 28 26 27" />
                        </Face>
                        <Face id="22" plane="-0.793356 -0.608758 0 -0.495722" album="Blasted" material="button_bm" texgens="0.608758 -0.793356 0 60.5642 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 31 30 28 29" />
                        </Face>
                        <Face id="23" plane="-0.608762 -0.793353 0 -0.495723" album="Blasted" material="button_bm" texgens="0.793353 -0.608762 0 64.7409 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 33 32 30 31" />
                        </Face>
                        <Face id="24" plane="-0.382681 -0.923881 -1.52824e-006 -0.495723" album="Blasted" material="button_bm" texgens="0.923881 -0.382681 0 68.9179 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 35 34 32 33" />
                        </Face>
                        <Face id="25" plane="-0.130526 -0.991445 -2.53978e-007 -0.495723" album="Blasted" material="button_bm" texgens="0.991445 -0.130526 0 73.0948 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 37 36 34 35" />
                        </Face>
                        <Face id="26" plane="0.130526 -0.991445 0 -0.495723" album="Blasted" material="button_bm" texgens="0.991445 0.130526 0 77.2714 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 39 38 36 37" />
                        </Face>
                        <Face id="27" plane="0.382687 -0.923878 1.55107e-006 -0.495722" album="Blasted" material="button_bm" texgens="0.923878 0.382687 0 81.4485 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 41 40 38 39" />
                        </Face>
                        <Face id="28" plane="0.608766 -0.79335 0 -0.495722" album="Blasted" material="button_bm" texgens="0.79335 0.608766 0 85.6251 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 43 42 40 41" />
                        </Face>
                        <Face id="29" plane="0.793353 -0.608762 0 -0.495722" album="Blasted" material="button_bm" texgens="0.608762 0.793353 0 89.802 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 45 44 42 43" />
                        </Face>
                        <Face id="30" plane="0.923882 -0.382677 -3.7446e-006 -0.495724" album="Blasted" material="button_bm" texgens="0.382677 0.923882 0 93.979 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 47 46 44 45" />
                        </Face>
                        <Face id="31" plane="0.991446 -0.130519 0 -0.495723" album="Blasted" material="button_bm" texgens="0.130527 0.991445 0 98.1556 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 47 3 2 46" />
                        </Face>
                        <Face id="32" plane="-0 0 -1 -0.5" album="Blasted" material="button_bm" texgens="-1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 46 2 0 4 6 8 10 12 14 16 18 20 22 24 26 28 30 32 34 36 38 40 42 44" />
                        </Face>
                        <Face id="33" plane="0 -0 1 0.25" album="Blasted" material="button_bm" texgens="1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 47 45 43 41 39 37 35 33 31 29 27 25 23 21 19 17 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="164" owner="9" type="999" pos="-46 0 -2.5" rot="1 0 0 0" scale="" transform="1 0 0 -46 0 1 0 0 0 0 1 -2.5 0 0 0 1" group="-1" locked="0" nextFaceID="35" nextVertexID="49">
                        <Vertices>
                            <Vertex pos="0.482963 0.129409 -0.5" />
                            <Vertex pos="0.482964 0.129409 -0.25" />
                            <Vertex pos="0.5 -2.98023e-008 -0.5" />
                            <Vertex pos="0.5 -2.98023e-008 -0.25" />
                            <Vertex pos="0.433013 0.25 -0.5" />
                            <Vertex pos="0.433014 0.25 -0.25" />
                            <Vertex pos="0.353553 0.353553 -0.5" />
                            <Vertex pos="0.353554 0.353553 -0.25" />
                            <Vertex pos="0.249999 0.433013 -0.5" />
                            <Vertex pos="0.25 0.433013 -0.25" />
                            <Vertex pos="0.129408 0.482963 -0.5" />
                            <Vertex pos="0.129406 0.482963 -0.25" />
                            <Vertex pos="-1.56844e-006 0.5 -0.5" />
                            <Vertex pos="0 0.5 -0.25" />
                            <Vertex pos="-0.129412 0.482962 -0.5" />
                            <Vertex pos="-0.129414 0.482962 -0.25" />
                            <Vertex pos="-0.249998 0.433014 -0.5" />
                            <Vertex pos="-0.249996 0.433014 -0.25" />
                            <Vertex pos="-0.353552 0.353555 -0.5" />
                            <Vertex pos="-0.353554 0.353555 -0.25" />
                            <Vertex pos="-0.433012 0.250002 -0.5" />
                            <Vertex pos="-0.433014 0.250002 -0.25" />
                            <Vertex pos="-0.482962 0.129411 -0.5" />
                            <Vertex pos="-0.482964 0.129411 -0.25" />
                            <Vertex pos="-0.5 5.40998e-007 -0.5" />
                            <Vertex pos="-0.5 5.40998e-007 -0.25" />
                            <Vertex pos="-0.482963 -0.129408 -0.5" />
                            <Vertex pos="-0.482964 -0.129408 -0.25" />
                            <Vertex pos="-0.433013 -0.249999 -0.5" />
                            <Vertex pos="-0.433014 -0.249999 -0.25" />
                            <Vertex pos="-0.353554 -0.353553 -0.5" />
                            <Vertex pos="-0.353554 -0.353553 -0.25" />
                            <Vertex pos="-0.25 -0.433013 -0.5" />
                            <Vertex pos="-0.25 -0.433013 -0.25" />
                            <Vertex pos="-0.129409 -0.482963 -0.5" />
                            <Vertex pos="-0.12941 -0.482963 -0.25" />
                            <Vertex pos="4.86453e-007 -0.5 -0.5" />
                            <Vertex pos="0 -0.5 -0.25" />
                            <Vertex pos="0.12941 -0.482963 -0.5" />
                            <Vertex pos="0.12941 -0.482963 -0.25" />
                            <Vertex pos="0.250001 -0.433012 -0.5" />
                            <Vertex pos="0.25 -0.433012 -0.25" />
                            <Vertex pos="0.353554 -0.353552 -0.5" />
                            <Vertex pos="0.353554 -0.353552 -0.25" />
                            <Vertex pos="0.433014 -0.249998 -0.5" />
                            <Vertex pos="0.433014 -0.249998 -0.25" />
                            <Vertex pos="0.482963 -0.129408 -0.5" />
                            <Vertex pos="0.482964 -0.129408 -0.25" />
                        </Vertices>
                        <Face id="8" plane="0.991446 0.130518 -4.01844e-006 -0.495724" album="Blasted" material="button_bm" texgens="-0.130526 0.991445 0 2.08842 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="9" plane="0.923881 0.382681 -3.7446e-006 -0.495724" album="Blasted" material="button_bm" texgens="-0.382681 0.923881 0 6.26522 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="10" plane="0.79335 0.608766 -3.21554e-006 -0.495724" album="Blasted" material="button_bm" texgens="-0.608766 0.79335 0 10.4422 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="11" plane="0.608763 0.793353 -2.4311e-006 -0.495723" album="Blasted" material="button_bm" texgens="-0.793353 0.608763 0 14.6189 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="12" plane="0.382681 0.923881 3.05648e-006 -0.495721" album="Blasted" material="button_bm" texgens="-0.923881 0.382681 0 18.7958 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="13" plane="0.130526 0.991445 -8.18886e-007 -0.495723" album="Blasted" material="button_bm" texgens="-0.991445 0.130525 0 22.9726 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="14" plane="-0.130532 0.991444 -1.05034e-006 -0.495723" album="Blasted" material="button_bm" texgens="-0.991444 -0.130532 0 27.1495 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="15" plane="-0.382681 0.92388 3.05648e-006 -0.495721" album="Blasted" material="button_bm" texgens="-0.923881 -0.382681 0 31.3262 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 17 16 14 15" />
                        </Face>
                        <Face id="16" plane="-0.608758 0.793356 -4.86216e-006 -0.495725" album="Blasted" material="button_bm" texgens="-0.793356 -0.608758 0 35.5031 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 19 18 16 17" />
                        </Face>
                        <Face id="17" plane="-0.79335 0.608766 -6.3365e-006 -0.495726" album="Blasted" material="button_bm" texgens="-0.608766 -0.79335 0 39.6797 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 21 20 18 19" />
                        </Face>
                        <Face id="18" plane="-0.923881 0.382681 -7.37905e-006 -0.495726" album="Blasted" material="button_bm" texgens="-0.382681 -0.923881 0 43.8569 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 23 22 20 21" />
                        </Face>
                        <Face id="19" plane="-0.991444 0.130532 0 -0.495722" album="Blasted" material="button_bm" texgens="-0.130533 -0.991444 0 48.0336 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 25 24 22 23" />
                        </Face>
                        <Face id="20" plane="-0.991445 -0.130527 -4.01844e-006 -0.495724" album="Blasted" material="button_bm" texgens="0.130525 -0.991445 0 52.2104 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 27 26 24 25" />
                        </Face>
                        <Face id="21" plane="-0.923881 -0.382681 -3.7446e-006 -0.495724" album="Blasted" material="button_bm" texgens="0.382683 -0.92388 0 56.3873 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 29 28 26 27" />
                        </Face>
                        <Face id="22" plane="-0.793356 -0.608758 0 -0.495722" album="Blasted" material="button_bm" texgens="0.608758 -0.793356 0 60.5642 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 31 30 28 29" />
                        </Face>
                        <Face id="23" plane="-0.608762 -0.793353 0 -0.495723" album="Blasted" material="button_bm" texgens="0.793353 -0.608762 0 64.7409 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 33 32 30 31" />
                        </Face>
                        <Face id="24" plane="-0.382681 -0.923881 -1.52824e-006 -0.495723" album="Blasted" material="button_bm" texgens="0.923881 -0.382681 0 68.9179 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 35 34 32 33" />
                        </Face>
                        <Face id="25" plane="-0.130526 -0.991445 -2.53978e-007 -0.495723" album="Blasted" material="button_bm" texgens="0.991445 -0.130526 0 73.0948 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 37 36 34 35" />
                        </Face>
                        <Face id="26" plane="0.130526 -0.991445 0 -0.495723" album="Blasted" material="button_bm" texgens="0.991445 0.130526 0 77.2714 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 39 38 36 37" />
                        </Face>
                        <Face id="27" plane="0.382687 -0.923878 1.55107e-006 -0.495722" album="Blasted" material="button_bm" texgens="0.923878 0.382687 0 81.4485 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 41 40 38 39" />
                        </Face>
                        <Face id="28" plane="0.608766 -0.79335 0 -0.495722" album="Blasted" material="button_bm" texgens="0.79335 0.608766 0 85.6251 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 43 42 40 41" />
                        </Face>
                        <Face id="29" plane="0.793353 -0.608762 0 -0.495722" album="Blasted" material="button_bm" texgens="0.608762 0.793353 0 89.802 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 45 44 42 43" />
                        </Face>
                        <Face id="30" plane="0.923882 -0.382677 -3.7446e-006 -0.495724" album="Blasted" material="button_bm" texgens="0.382677 0.923882 0 93.979 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 47 46 44 45" />
                        </Face>
                        <Face id="31" plane="0.991446 -0.130519 0 -0.495723" album="Blasted" material="button_bm" texgens="0.130527 0.991445 0 98.1556 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 47 3 2 46" />
                        </Face>
                        <Face id="32" plane="-0 0 -1 -0.5" album="Blasted" material="button_bm" texgens="-1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 46 2 0 4 6 8 10 12 14 16 18 20 22 24 26 28 30 32 34 36 38 40 42 44" />
                        </Face>
                        <Face id="33" plane="0 -0 1 0.25" album="Blasted" material="button_bm" texgens="1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 47 45 43 41 39 37 35 33 31 29 27 25 23 21 19 17 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="166" owner="4" type="4" pos="45.5 0.5 5.25" rot="1 0 0 0" scale="" transform="1 0 0 45.5 0 1 0 0.5 0 0 1 5.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0 0.25" />
                            <Vertex pos="1 0 -0.25" />
                            <Vertex pos="1 -1 0.25" />
                            <Vertex pos="1 -1 -0.25" />
                            <Vertex pos="0 0 0.25" />
                            <Vertex pos="0 0 -0.25" />
                            <Vertex pos="0 -1 0.25" />
                            <Vertex pos="0 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3" texgens="0 1 0 256 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0" album="" material="bm_grid_blank3" texgens="0 -1 0 256 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0" album="" material="bm_grid_blank3" texgens="-1 0 0 1792 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank3" texgens="1 0 0 -1280 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_grid_blank2" texgens="1 0 0 128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank3" texgens="-1 0 0 1792 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="167" owner="8" type="4" pos="-0.5 50.5 7.25" rot="1 0 0 0" scale="" transform="1 0 0 -0.5 0 1 0 50.5 0 0 1 7.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0 0.25" />
                            <Vertex pos="1 0 -0.25" />
                            <Vertex pos="1 -1 0.25" />
                            <Vertex pos="1 -1 -0.25" />
                            <Vertex pos="0 0 0.25" />
                            <Vertex pos="0 0 -0.25" />
                            <Vertex pos="0 -1 0.25" />
                            <Vertex pos="0 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3" texgens="0 1 0 256 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0" album="" material="bm_grid_blank3" texgens="0 -1 0 256 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0" album="" material="bm_grid_blank3" texgens="-1 0 0 1792 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank3" texgens="1 0 0 -1280 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_grid_blank2" texgens="1 0 0 128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank3" texgens="-1 0 0 1792 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="168" owner="12" type="4" pos="-46.5 0.5 -2.75" rot="1 0 0 0" scale="" transform="1 0 0 -46.5 0 1 0 0.5 0 0 1 -2.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0 0.25" />
                            <Vertex pos="1 0 -0.25" />
                            <Vertex pos="1 -1 0.25" />
                            <Vertex pos="1 -1 -0.25" />
                            <Vertex pos="0 0 0.25" />
                            <Vertex pos="0 0 -0.25" />
                            <Vertex pos="0 -1 0.25" />
                            <Vertex pos="0 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3" texgens="0 1 0 256 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0" album="" material="bm_grid_blank3" texgens="0 -1 0 256 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0" album="" material="bm_grid_blank3" texgens="-1 0 0 1792 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank3" texgens="1 0 0 -1280 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_grid_blank2" texgens="1 0 0 128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank3" texgens="-1 0 0 1792 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="169" owner="16" type="4" pos="-0.5 -47.5 6.25" rot="1 0 0 0" scale="" transform="1 0 0 -0.5 0 1 0 -47.5 0 0 1 6.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0 0.25" />
                            <Vertex pos="1 0 -0.25" />
                            <Vertex pos="1 -1 0.25" />
                            <Vertex pos="1 -1 -0.25" />
                            <Vertex pos="0 0 0.25" />
                            <Vertex pos="0 0 -0.25" />
                            <Vertex pos="0 -1 0.25" />
                            <Vertex pos="0 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3" texgens="0 1 0 256 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0" album="" material="bm_grid_blank3" texgens="0 -1 0 256 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0" album="" material="bm_grid_blank3" texgens="-1 0 0 1792 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank3" texgens="1 0 0 -1280 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_grid_blank2" texgens="1 0 0 128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank3" texgens="-1 0 0 1792 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="170" owner="20" type="4" pos="2 6 -10.75" rot="1 0 0 0" scale="" transform="1 0 0 2 0 1 0 6 0 0 1 -10.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0 0.25" />
                            <Vertex pos="1 0 -0.25" />
                            <Vertex pos="1 -1 0.25" />
                            <Vertex pos="1 -1 -0.25" />
                            <Vertex pos="0 0 0.25" />
                            <Vertex pos="0 0 -0.25" />
                            <Vertex pos="0 -1 0.25" />
                            <Vertex pos="0 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3" texgens="0 1 0 256 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0" album="" material="bm_grid_blank3" texgens="0 -1 0 256 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0" album="" material="bm_grid_blank3" texgens="-1 0 0 1792 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank3" texgens="1 0 0 -1280 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_grid_blank2" texgens="1 0 0 128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank3" texgens="-1 0 0 1792 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="171" owner="24" type="4" pos="0 6 -10.75" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 6 0 0 1 -10.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0 0.25" />
                            <Vertex pos="1 0 -0.25" />
                            <Vertex pos="1 -1 0.25" />
                            <Vertex pos="1 -1 -0.25" />
                            <Vertex pos="0 0 0.25" />
                            <Vertex pos="0 0 -0.25" />
                            <Vertex pos="0 -1 0.25" />
                            <Vertex pos="0 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3" texgens="0 1 0 256 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0" album="" material="bm_grid_blank3" texgens="0 -1 0 256 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0" album="" material="bm_grid_blank3" texgens="-1 0 0 1792 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank3" texgens="1 0 0 -1280 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_grid_blank2" texgens="1 0 0 128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank3" texgens="-1 0 0 1792 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="172" owner="28" type="4" pos="-2 6 -10.75" rot="1 0 0 0" scale="" transform="1 0 0 -2 0 1 0 6 0 0 1 -10.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0 0.25" />
                            <Vertex pos="1 0 -0.25" />
                            <Vertex pos="1 -1 0.25" />
                            <Vertex pos="1 -1 -0.25" />
                            <Vertex pos="0 0 0.25" />
                            <Vertex pos="0 0 -0.25" />
                            <Vertex pos="0 -1 0.25" />
                            <Vertex pos="0 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3" texgens="0 1 0 256 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0" album="" material="bm_grid_blank3" texgens="0 -1 0 256 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0" album="" material="bm_grid_blank3" texgens="-1 0 0 1792 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank3" texgens="1 0 0 -1280 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_grid_blank2" texgens="1 0 0 128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank3" texgens="-1 0 0 1792 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="173" owner="32" type="4" pos="-4 6 -10.75" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 6 0 0 1 -10.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0 0.25" />
                            <Vertex pos="1 0 -0.25" />
                            <Vertex pos="1 -1 0.25" />
                            <Vertex pos="1 -1 -0.25" />
                            <Vertex pos="0 0 0.25" />
                            <Vertex pos="0 0 -0.25" />
                            <Vertex pos="0 -1 0.25" />
                            <Vertex pos="0 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank3" texgens="0 1 0 256 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0" album="" material="bm_grid_blank3" texgens="0 -1 0 256 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0" album="" material="bm_grid_blank3" texgens="-1 0 0 1792 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank3" texgens="1 0 0 -1280 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_grid_blank2" texgens="1 0 0 128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank3" texgens="-1 0 0 1792 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                </Brushes>
            </InteriorMap>
        </DetailLevel>
    </DetailLevels>
</ConstructorScene>
