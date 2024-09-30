<?xml version="1.0" encoding="utf-8" standalone="yes" ?>
<!--Torque Constructor Scene document http://www.garagegames.com-->
<ConstructorScene version="4" creator="Torque Constructor" date="2024/09/26 21:45:07">
    <Sunlight azimuth="180" elevation="35" color="255 255 255" ambient="64 64 64" />
    <LightingOptions lightingSystem="" ineditor_defaultLightmapSize="256" ineditor_maxLightmapSize="256" ineditor_lightingPerformanceHint="0" ineditor_shadowPerformanceHint="1" ineditor_TAPCompatibility="0" ineditor_useSunlight="0" export_defaultLightmapSize="256" export_maxLightmapSize="256" export_lightingPerformanceHint="0" export_shadowPerformanceHint="1" export_TAPCompatibility="0" export_useSunlight="0" />
    <GameTypes>
        <GameType name="Constructor" />
        <GameType name="Torque" />
    </GameTypes>
    <SceneShapes nextShapeID="33">
        <SceneShape id="0" type="1" entityID="2" dl="0" group="-1" locked="0" />
        <SceneShape id="1" type="1" entityID="3" dl="0" group="-1" locked="0" />
        <SceneShape id="2" type="1" entityID="4" dl="0" group="-1" locked="0" />
        <SceneShape id="3" type="1" entityID="6" dl="0" group="-1" locked="0" />
        <SceneShape id="4" type="1" entityID="7" dl="0" group="-1" locked="0" />
        <SceneShape id="5" type="1" entityID="8" dl="0" group="-1" locked="0" />
        <SceneShape id="6" type="1" entityID="10" dl="0" group="-1" locked="0" />
        <SceneShape id="7" type="1" entityID="11" dl="0" group="-1" locked="0" />
        <SceneShape id="8" type="1" entityID="12" dl="0" group="-1" locked="0" />
        <SceneShape id="9" type="1" entityID="13" dl="0" group="-1" locked="0" />
        <SceneShape id="10" type="1" entityID="14" dl="0" group="-1" locked="0" />
        <SceneShape id="11" type="1" entityID="16" dl="0" group="-1" locked="0" />
        <SceneShape id="12" type="1" entityID="17" dl="0" group="-1" locked="0" />
        <SceneShape id="13" type="1" entityID="18" dl="0" group="-1" locked="0" />
        <SceneShape id="14" type="1" entityID="20" dl="0" group="-1" locked="0" />
        <SceneShape id="15" type="1" entityID="21" dl="0" group="-1" locked="0" />
        <SceneShape id="16" type="1" entityID="22" dl="0" group="-1" locked="0" />
        <SceneShape id="17" type="1" entityID="24" dl="0" group="-1" locked="0" />
        <SceneShape id="18" type="1" entityID="25" dl="0" group="-1" locked="0" />
        <SceneShape id="19" type="1" entityID="28" dl="0" group="-1" locked="0" />
        <SceneShape id="20" type="1" entityID="29" dl="0" group="-1" locked="0" />
        <SceneShape id="21" type="1" entityID="30" dl="0" group="-1" locked="0" />
        <SceneShape id="22" type="1" entityID="31" dl="0" group="-1" locked="0" />
        <SceneShape id="23" type="1" entityID="32" dl="0" group="-1" locked="0" />
        <SceneShape id="24" type="1" entityID="34" dl="0" group="-1" locked="0" />
        <SceneShape id="25" type="1" entityID="35" dl="0" group="-1" locked="0" />
        <SceneShape id="26" type="1" entityID="36" dl="0" group="-1" locked="0" />
        <SceneShape id="27" type="1" entityID="38" dl="0" group="-1" locked="0" />
        <SceneShape id="28" type="1" entityID="39" dl="0" group="-1" locked="0" />
        <SceneShape id="29" type="1" entityID="40" dl="0" group="-1" locked="0" />
        <SceneShape id="30" type="1" entityID="42" dl="0" group="-1" locked="0" />
        <SceneShape id="31" type="1" entityID="43" dl="0" group="-1" locked="0" />
        <SceneShape id="32" type="1" entityID="44" dl="0" group="-1" locked="0" />
    </SceneShapes>
    <DetailLevels current="0">
        <DetailLevel minPixelSize="0" actionCenter="0 0 0">
            <InteriorMap brushScale="32" lightScale="8" ambientColor="0 0 0" ambientColorEmerg="0 0 0">
                <Entities nextEntityID="45">
                    <Entity id="0" classname="worldspawn" gametype="Torque" isPointEntity="0">
                        <Properties detail_number="0" min_pixels="250" geometry_scale="32" light_geometry_scale="8" light_smoothing_scale="4.0" light_mesh_scale="1.0" ambient_color="0 0 0" emergency_ambient_color="0 0 0" mapversion="220" />
                    </Entity>
                    <Entity id="1" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="-1" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="2" classname="path_node" gametype="Torque" isPointEntity="1" origin="3 -16 0.75" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="3" classname="path_node" gametype="Torque" isPointEntity="1" origin="1 -16 0.75" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="4" classname="path_node" gametype="Torque" isPointEntity="1" origin="3 -16 0.75" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="5" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="-1" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="6" classname="path_node" gametype="Torque" isPointEntity="1" origin="1 -19 1.25" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="7" classname="path_node" gametype="Torque" isPointEntity="1" origin="3 -19 1.25" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="8" classname="path_node" gametype="Torque" isPointEntity="1" origin="1 -19 1.25" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="9" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="-1" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="10" classname="path_node" gametype="Torque" isPointEntity="1" origin="-19 25 4.5" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="11" classname="path_node" gametype="Torque" isPointEntity="1" origin="-19 27 4.5" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="12" classname="path_node" gametype="Torque" isPointEntity="1" origin="-19 27 4.5" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="13" classname="path_node" gametype="Torque" isPointEntity="1" origin="-19 25 4.5" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="14" classname="path_node" gametype="Torque" isPointEntity="1" origin="-19 25 4.5" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="15" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="-1" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="16" classname="path_node" gametype="Torque" isPointEntity="1" origin="2 3 4.75" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="17" classname="path_node" gametype="Torque" isPointEntity="1" origin="2 1 4.75" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="18" classname="path_node" gametype="Torque" isPointEntity="1" origin="2 3 4.75" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="19" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="-1" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="20" classname="path_node" gametype="Torque" isPointEntity="1" origin="6 1 5.25" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="21" classname="path_node" gametype="Torque" isPointEntity="1" origin="6 3 5.25" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="22" classname="path_node" gametype="Torque" isPointEntity="1" origin="6 1 5.25" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="23" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="0" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="24" classname="path_node" gametype="Torque" isPointEntity="1" origin="11 8 5.75" direction="0 -0 -0">
                        <Properties next_time="2000" smoothing="2" />
                    </Entity>
                    <Entity id="25" classname="path_node" gametype="Torque" isPointEntity="1" origin="11 8 9.75" direction="0 -0 -0">
                        <Properties next_time="2000" smoothing="2" />
                    </Entity>
                    <Entity id="26" classname="trigger" gametype="Torque" isPointEntity="0">
                        <Properties TargetTime="99999" datablock="TriggerGotoTarget" />
                    </Entity>
                    <Entity id="27" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="-1" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="28" classname="path_node" gametype="Torque" isPointEntity="1" origin="-6 -26 10" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="29" classname="path_node" gametype="Torque" isPointEntity="1" origin="-6 -28 10" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="30" classname="path_node" gametype="Torque" isPointEntity="1" origin="-6 -28 10" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="31" classname="path_node" gametype="Torque" isPointEntity="1" origin="-6 -26 10" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="32" classname="path_node" gametype="Torque" isPointEntity="1" origin="-6 -26 10" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="33" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="-1" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="34" classname="path_node" gametype="Torque" isPointEntity="1" origin="-7.5 33 6.75" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="35" classname="path_node" gametype="Torque" isPointEntity="1" origin="-7.5 31 6.75" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="36" classname="path_node" gametype="Torque" isPointEntity="1" origin="-7.5 33 6.75" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="37" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="-1" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="38" classname="path_node" gametype="Torque" isPointEntity="1" origin="-11 31 7.25" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="39" classname="path_node" gametype="Torque" isPointEntity="1" origin="-11 33 7.25" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="40" classname="path_node" gametype="Torque" isPointEntity="1" origin="-11 31 7.25" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="41" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="-1" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="42" classname="path_node" gametype="Torque" isPointEntity="1" origin="-20.5 33 8.75" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="43" classname="path_node" gametype="Torque" isPointEntity="1" origin="-20.5 31 8.75" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="44" classname="path_node" gametype="Torque" isPointEntity="1" origin="-20.5 33 8.75" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                </Entities>
                <Brushes nextBrushID="236">
                    <Brush id="0" owner="0" type="0" pos="0 -1 0.25" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -1 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 3 0.25" />
                            <Vertex pos="2 3 -0.25" />
                            <Vertex pos="2 -3 0.25" />
                            <Vertex pos="2 -3 -0.25" />
                            <Vertex pos="-2 3 0.25" />
                            <Vertex pos="-2 3 -0.25" />
                            <Vertex pos="-2 -3 0.25" />
                            <Vertex pos="-2 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 512 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="1" owner="0" type="0" pos="1 -6 0.25" rot="1 0 0 0" scale="" transform="1 0 0 1 0 1 0 -6 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 0.25" />
                            <Vertex pos="1 2 -0.25" />
                            <Vertex pos="3 -2 0.25" />
                            <Vertex pos="3 -2 -0.25" />
                            <Vertex pos="-3 2 0.25" />
                            <Vertex pos="-3 2 -0.25" />
                            <Vertex pos="-1 -2 0.25" />
                            <Vertex pos="-1 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.894427 0.447214 0 -1.78885" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.894427 -0.447214 0 -1.78885" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0.5 0 512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 -0.5 0 256 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="2" owner="0" type="0" pos="2 -11 0.25" rot="1 0 0 0" scale="" transform="1 0 0 2 0 1 0 -11 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 3 0.25" />
                            <Vertex pos="2 3 -0.25" />
                            <Vertex pos="2 -3 0.25" />
                            <Vertex pos="2 -3 -0.25" />
                            <Vertex pos="-2 3 0.25" />
                            <Vertex pos="-2 3 -0.25" />
                            <Vertex pos="-2 -3 0.25" />
                            <Vertex pos="-2 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 512 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="3" owner="0" type="0" pos="0 -25 1.75" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -25 0 0 1 1.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 0.25" />
                            <Vertex pos="2 4 -0.25" />
                            <Vertex pos="2 -4 0.25" />
                            <Vertex pos="2 -4 -0.25" />
                            <Vertex pos="-2 4 0.25" />
                            <Vertex pos="-2 4 -0.25" />
                            <Vertex pos="-2 -4 0.25" />
                            <Vertex pos="-2 -4 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 1024 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 512 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="4" owner="0" type="0" pos="-4 -27 1.75" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 -27 0 0 1 1.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 512 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="5" owner="0" type="0" pos="-6.5 -27 1.875" rot="1 0 0 0" scale="" transform="1 0 0 -6.5 0 1 0 -27 0 0 1 1.875 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 2 0.125" />
                            <Vertex pos="0.5 2 -0.375" />
                            <Vertex pos="0.5 -2 0.125" />
                            <Vertex pos="0.5 -2 -0.375" />
                            <Vertex pos="-0.5 2 0.375" />
                            <Vertex pos="-0.5 2 -0.125" />
                            <Vertex pos="-0.5 -2 0.375" />
                            <Vertex pos="-0.5 -2 -0.125" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 1536 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -768 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 896 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970143 -0.242536" album="" material="bm_tile09_C" texgens="1 0 0 896 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970143 -0.242536" album="" material="bm_grid_blank2" texgens="-1 0 0 -192 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="6" owner="0" type="0" pos="-8 -27 2.5" rot="1 0 0 0" scale="" transform="1 0 0 -8 0 1 0 -27 0 0 1 2.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 -0.25" />
                            <Vertex pos="1 2 -0.75" />
                            <Vertex pos="1 -2 -0.25" />
                            <Vertex pos="1 -2 -0.75" />
                            <Vertex pos="-1 2 0.75" />
                            <Vertex pos="-1 2 0.25" />
                            <Vertex pos="-1 -2 0.75" />
                            <Vertex pos="-1 -2 0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 1536 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -640 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 768 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.447214 0 0.894427 -0.223607" album="" material="bm_tile09_C" texgens="1 0 0 512 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.447214 0 -0.894427 -0.223607" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="7" owner="0" type="0" pos="-9.5 -27 3.125" rot="1 0 0 0" scale="" transform="1 0 0 -9.5 0 1 0 -27 0 0 1 3.125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 2 0.125" />
                            <Vertex pos="0.5 2 -0.375" />
                            <Vertex pos="0.5 -2 0.125" />
                            <Vertex pos="0.5 -2 -0.375" />
                            <Vertex pos="-0.5 2 0.375" />
                            <Vertex pos="-0.5 2 -0.125" />
                            <Vertex pos="-0.5 -2 0.375" />
                            <Vertex pos="-0.5 -2 -0.125" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 -288 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 1536 0 0 -1 -288 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -768 0 0 -1 -288 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 896 0 0 -1 -288 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970143 -0.242536" album="" material="bm_tile09_C" texgens="1 0 0 128 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970143 -0.242536" album="" material="bm_grid_blank2" texgens="-1 0 0 192 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="8" owner="0" type="0" pos="-12 -27 3.25" rot="1 0 0 0" scale="" transform="1 0 0 -12 0 1 0 -27 0 0 1 3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 512 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="9" owner="0" type="0" pos="-16 -27 3.25" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 -27 0 0 1 3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_trim" texgens="0 -1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_friction_ice" texgens="1 0 0 -4096 0 -1 0 6912 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="10" owner="0" type="0" pos="-20 -28 3.25" rot="1 0 0 0" scale="" transform="1 0 0 -20 0 1 0 -28 0 0 1 3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 0.25" />
                            <Vertex pos="2 1 -0.25" />
                            <Vertex pos="2 -1 0.25" />
                            <Vertex pos="2 -1 -0.25" />
                            <Vertex pos="-2 1 0.25" />
                            <Vertex pos="-2 1 -0.25" />
                            <Vertex pos="-2 -1 0.25" />
                            <Vertex pos="-2 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 1792 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_trim" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_friction_ice" texgens="1 0 0 -5120 0 -1 0 7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="11" owner="0" type="0" pos="-24 -27 3.25" rot="1 0 0 0" scale="" transform="1 0 0 -24 0 1 0 -27 0 0 1 3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_trim" texgens="0 1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_trim" texgens="0 -1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_friction_ice" texgens="1 0 0 -6144 0 -1 0 6912 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="12" owner="0" type="0" pos="-28 -26 3.25" rot="1 0 0 0" scale="" transform="1 0 0 -28 0 1 0 -26 0 0 1 3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 0.25" />
                            <Vertex pos="2 1 -0.25" />
                            <Vertex pos="2 -1 0.25" />
                            <Vertex pos="2 -1 -0.25" />
                            <Vertex pos="-2 1 0.25" />
                            <Vertex pos="-2 1 -0.25" />
                            <Vertex pos="-2 -1 0.25" />
                            <Vertex pos="-2 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 1792 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_trim" texgens="1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_friction_ice" texgens="1 0 0 -7168 0 -1 0 6656 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="13" owner="0" type="0" pos="-32 -27 3.25" rot="1 0 0 0" scale="" transform="1 0 0 -32 0 1 0 -27 0 0 1 3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_trim" texgens="0 1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_friction_ice" texgens="1 0 0 -8192 0 -1 0 6912 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="14" owner="0" type="0" pos="-36 -27 3.25" rot="1 0 0 0" scale="" transform="1 0 0 -36 0 1 0 -27 0 0 1 3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 512 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="15" owner="0" type="0" pos="-40 -25 3.25" rot="1 0 0 0" scale="" transform="1 0 0 -40 0 1 0 -25 0 0 1 3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 0.25" />
                            <Vertex pos="2 4 -0.25" />
                            <Vertex pos="2 -4 0.25" />
                            <Vertex pos="2 -4 -0.25" />
                            <Vertex pos="-2 4 0.25" />
                            <Vertex pos="-2 4 -0.25" />
                            <Vertex pos="-2 -4 0.25" />
                            <Vertex pos="-2 -4 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 1024 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 512 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="16" owner="0" type="0" pos="-40 -19 7.75" rot="1 0 0 0" scale="" transform="1 0 0 -40 0 1 0 -19 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 512 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="17" owner="0" type="0" pos="4 8 -3" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 8 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 6 13" />
                            <Vertex pos="6 6 -13" />
                            <Vertex pos="6 -6 13" />
                            <Vertex pos="6 -6 -13" />
                            <Vertex pos="-6 6 13" />
                            <Vertex pos="-6 6 -13" />
                            <Vertex pos="-6 -6 13" />
                            <Vertex pos="-6 -6 -13" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank1" texgens="0 1 0 768 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank1" texgens="0 -1 0 -512 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_grid_blank1" texgens="-1 0 0 -256 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_grid_blank1" texgens="1 0 0 512 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -13" album="" material="bm_friction_ice" texgens="1 0 0 1024 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -13" album="" material="bm_grid_blank1" texgens="-1 0 0 -256 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="18" owner="0" type="0" pos="-3 1 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -3 0 1 0 1 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 1 0.25" />
                            <Vertex pos="3 1 -0.25" />
                            <Vertex pos="3 -1 0.25" />
                            <Vertex pos="3 -1 -0.25" />
                            <Vertex pos="-3 1 0.25" />
                            <Vertex pos="-3 1 -0.25" />
                            <Vertex pos="-3 -1 0.25" />
                            <Vertex pos="-3 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_edge_white" texgens="0 -1 0 256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 256 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="19" owner="0" type="0" pos="-4 4 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 4 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 0 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="20" owner="0" type="0" pos="-4 12 2.75" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 12 0 0 1 2.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 0 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="21" owner="0" type="0" pos="-4 8 3.5" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 8 0 0 1 3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 -0.5" />
                            <Vertex pos="2 2 -1" />
                            <Vertex pos="2 -2 1" />
                            <Vertex pos="2 -2 0.5" />
                            <Vertex pos="-2 2 -0.5" />
                            <Vertex pos="-2 2 -1" />
                            <Vertex pos="-2 -2 1" />
                            <Vertex pos="-2 -2 0.5" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.351123 0.936329 -0.234082" album="" material="bm_tile09_C" texgens="1 0 0 0 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.351123 -0.936329 -0.234082" album="" material="bm_grid_blank2" texgens="-1 0 0 256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="22" owner="0" type="0" pos="-4.5 17 2.75" rot="1 0 0 0" scale="" transform="1 0 0 -4.5 0 1 0 17 0 0 1 2.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.5 3 0.25" />
                            <Vertex pos="1.5 3 -0.25" />
                            <Vertex pos="2.5 -3 0.25" />
                            <Vertex pos="2.5 -3 -0.25" />
                            <Vertex pos="-2.5 3 0.25" />
                            <Vertex pos="-2.5 3 -0.25" />
                            <Vertex pos="-1.5 -3 0.25" />
                            <Vertex pos="-1.5 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.986394 0.164399 0 -1.97279" album="" material="bm_edge_white" texgens="0 1 0 384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.986394 -0.164399 0 -1.97279" album="" material="bm_edge_white" texgens="0 -1 0 -256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0.166667 0 511.998 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 -0.166667 0 256 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="23" owner="0" type="0" pos="-5 23 2.75" rot="1 0 0 0" scale="" transform="1 0 0 -5 0 1 0 23 0 0 1 2.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 3 0.25" />
                            <Vertex pos="2 3 -0.25" />
                            <Vertex pos="2 -3 0.25" />
                            <Vertex pos="2 -3 -0.25" />
                            <Vertex pos="-2 3 0.25" />
                            <Vertex pos="-2 3 -0.25" />
                            <Vertex pos="-2 -3 0.25" />
                            <Vertex pos="-2 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_trim" texgens="0 -1 0 -256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 0 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 256 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="24" owner="0" type="0" pos="-35 26 6.25" rot="1 0 0 0" scale="" transform="1 0 0 -35 0 1 0 26 0 0 1 6.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 0.25" />
                            <Vertex pos="4 2 -0.25" />
                            <Vertex pos="4 -2 0.25" />
                            <Vertex pos="4 -2 -0.25" />
                            <Vertex pos="-4 2 0.25" />
                            <Vertex pos="-4 2 -0.25" />
                            <Vertex pos="-4 -2 0.25" />
                            <Vertex pos="-4 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_trim" texgens="0 1 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_edge_white" texgens="0 -1 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 -512 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="25" owner="0" type="0" pos="-37 20 6.25" rot="1 0 0 0" scale="" transform="1 0 0 -37 0 1 0 20 0 0 1 6.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 0.25" />
                            <Vertex pos="2 4 -0.25" />
                            <Vertex pos="2 -4 0.25" />
                            <Vertex pos="2 -4 -0.25" />
                            <Vertex pos="-2 4 0.25" />
                            <Vertex pos="-2 4 -0.25" />
                            <Vertex pos="-2 -4 0.25" />
                            <Vertex pos="-2 -4 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 1152 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 -1024 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 -1024 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 768 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="26" owner="0" type="0" pos="10 1 5.75" rot="1 0 0 0" scale="" transform="1 0 0 10 0 1 0 1 0 0 1 5.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 0.25" />
                            <Vertex pos="2 1 -0.25" />
                            <Vertex pos="2 -1 0.25" />
                            <Vertex pos="2 -1 -0.25" />
                            <Vertex pos="-2 1 0.25" />
                            <Vertex pos="-2 1 -0.25" />
                            <Vertex pos="-2 -1 0.25" />
                            <Vertex pos="-2 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 0 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 256 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="27" owner="0" type="0" pos="11 4 5.75" rot="1 0 0 0" scale="" transform="1 0 0 11 0 1 0 4 0 0 1 5.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 0.25" />
                            <Vertex pos="1 2 -0.25" />
                            <Vertex pos="1 -2 0.25" />
                            <Vertex pos="1 -2 -0.25" />
                            <Vertex pos="-1 2 0.25" />
                            <Vertex pos="-1 2 -0.25" />
                            <Vertex pos="-1 -2 0.25" />
                            <Vertex pos="-1 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 256 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 128 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="28" owner="0" type="0" pos="4 3 12" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 3 0 0 1 12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 1 2" />
                            <Vertex pos="6 1 -2" />
                            <Vertex pos="6 -1 2" />
                            <Vertex pos="6 -1 -2" />
                            <Vertex pos="-6 1 2" />
                            <Vertex pos="-6 1 -2" />
                            <Vertex pos="-6 -1 2" />
                            <Vertex pos="-6 -1 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank1" texgens="0 1 0 128 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank1" texgens="0 -1 0 128 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank1" texgens="-1 0 0 -256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank1" texgens="1 0 0 512 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_grid_blank1" texgens="1 0 0 512 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 -256 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="29" owner="0" type="0" pos="4 13 12" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 13 0 0 1 12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 1 2" />
                            <Vertex pos="6 1 -2" />
                            <Vertex pos="6 -1 2" />
                            <Vertex pos="6 -1 -2" />
                            <Vertex pos="-6 1 2" />
                            <Vertex pos="-6 1 -2" />
                            <Vertex pos="-6 -1 2" />
                            <Vertex pos="-6 -1 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank1" texgens="0 1 0 128 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank1" texgens="0 -1 0 128 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank1" texgens="-1 0 0 -256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank1" texgens="1 0 0 512 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_grid_blank1" texgens="1 0 0 512 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 -256 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="30" owner="0" type="0" pos="-1 5 12" rot="1 0 0 0" scale="" transform="1 0 0 -1 0 1 0 5 0 0 1 12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 2" />
                            <Vertex pos="1 1 -2" />
                            <Vertex pos="1 -1 2" />
                            <Vertex pos="1 -1 -2" />
                            <Vertex pos="-1 1 2" />
                            <Vertex pos="-1 1 -2" />
                            <Vertex pos="-1 -1 2" />
                            <Vertex pos="-1 -1 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank1" texgens="0 1 0 128 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank1" texgens="0 -1 0 128 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank1" texgens="-1 0 0 384 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank1" texgens="1 0 0 -128 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_grid_blank1" texgens="1 0 0 -128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 384 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="31" owner="0" type="0" pos="-1 11 12" rot="1 0 0 0" scale="" transform="1 0 0 -1 0 1 0 11 0 0 1 12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 2" />
                            <Vertex pos="1 1 -2" />
                            <Vertex pos="1 -1 2" />
                            <Vertex pos="1 -1 -2" />
                            <Vertex pos="-1 1 2" />
                            <Vertex pos="-1 1 -2" />
                            <Vertex pos="-1 -1 2" />
                            <Vertex pos="-1 -1 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank1" texgens="0 1 0 128 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank1" texgens="0 -1 0 128 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank1" texgens="-1 0 0 384 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank1" texgens="1 0 0 -128 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_grid_blank1" texgens="1 0 0 -128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 384 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="32" owner="0" type="0" pos="9 5 12" rot="1 0 0 0" scale="" transform="1 0 0 9 0 1 0 5 0 0 1 12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 2" />
                            <Vertex pos="1 1 -2" />
                            <Vertex pos="1 -1 2" />
                            <Vertex pos="1 -1 -2" />
                            <Vertex pos="-1 1 2" />
                            <Vertex pos="-1 1 -2" />
                            <Vertex pos="-1 -1 2" />
                            <Vertex pos="-1 -1 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank1" texgens="0 1 0 128 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank1" texgens="0 -1 0 128 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank1" texgens="-1 0 0 384 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank1" texgens="1 0 0 -128 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_grid_blank1" texgens="1 0 0 -128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 384 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="33" owner="0" type="0" pos="9 11 12" rot="1 0 0 0" scale="" transform="1 0 0 9 0 1 0 11 0 0 1 12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 2" />
                            <Vertex pos="1 1 -2" />
                            <Vertex pos="1 -1 2" />
                            <Vertex pos="1 -1 -2" />
                            <Vertex pos="-1 1 2" />
                            <Vertex pos="-1 1 -2" />
                            <Vertex pos="-1 -1 2" />
                            <Vertex pos="-1 -1 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank1" texgens="0 1 0 128 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank1" texgens="0 -1 0 128 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank1" texgens="-1 0 0 384 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank1" texgens="1 0 0 -128 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_grid_blank1" texgens="1 0 0 -128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 384 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="34" owner="0" type="0" pos="3 8 16" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 8 0 0 1 16 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 6 2" />
                            <Vertex pos="5 6 -2" />
                            <Vertex pos="5 -6 2" />
                            <Vertex pos="5 -6 -2" />
                            <Vertex pos="-5 6 2" />
                            <Vertex pos="-5 6 -2" />
                            <Vertex pos="-5 -6 2" />
                            <Vertex pos="-5 -6 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_grid_blank1" texgens="0 1 0 768 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -5" album="" material="bm_grid_blank1" texgens="0 -1 0 -512 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_grid_blank1" texgens="-1 0 0 -128 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_grid_blank1" texgens="1 0 0 384 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_friction_ice" texgens="1 0 0 768 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 -128 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="35" owner="0" type="0" pos="8 3 20" rot="1 0 0 0" scale="" transform="1 0 0 8 0 1 0 3 0 0 1 20 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 2" />
                            <Vertex pos="2 1 -2" />
                            <Vertex pos="2 -1 2" />
                            <Vertex pos="2 -1 -2" />
                            <Vertex pos="-2 1 2" />
                            <Vertex pos="-2 1 -2" />
                            <Vertex pos="-2 -1 2" />
                            <Vertex pos="-2 -1 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 128 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 128 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank1" texgens="-1 0 0 -768 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank1" texgens="1 0 0 1024 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_grid_blank1" texgens="1 0 0 1024 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 -768 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="36" owner="0" type="0" pos="4 13 20" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 13 0 0 1 20 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 1 2" />
                            <Vertex pos="6 1 -2" />
                            <Vertex pos="6 -1 2" />
                            <Vertex pos="6 -1 -2" />
                            <Vertex pos="-6 1 2" />
                            <Vertex pos="-6 1 -2" />
                            <Vertex pos="-6 -1 2" />
                            <Vertex pos="-6 -1 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank1" texgens="0 1 0 128 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank1" texgens="0 -1 0 128 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank1" texgens="-1 0 0 -256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank1" texgens="1 0 0 512 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_grid_blank1" texgens="1 0 0 512 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 -256 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="37" owner="0" type="0" pos="9 5 20" rot="1 0 0 0" scale="" transform="1 0 0 9 0 1 0 5 0 0 1 20 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 2" />
                            <Vertex pos="1 1 -2" />
                            <Vertex pos="1 -1 2" />
                            <Vertex pos="1 -1 -2" />
                            <Vertex pos="-1 1 2" />
                            <Vertex pos="-1 1 -2" />
                            <Vertex pos="-1 -1 2" />
                            <Vertex pos="-1 -1 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank1" texgens="0 1 0 128 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank1" texgens="0 -1 0 128 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank1" texgens="-1 0 0 384 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank1" texgens="1 0 0 -128 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_grid_blank1" texgens="1 0 0 -128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 384 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="38" owner="0" type="0" pos="9 11 20" rot="1 0 0 0" scale="" transform="1 0 0 9 0 1 0 11 0 0 1 20 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 2" />
                            <Vertex pos="1 1 -2" />
                            <Vertex pos="1 -1 2" />
                            <Vertex pos="1 -1 -2" />
                            <Vertex pos="-1 1 2" />
                            <Vertex pos="-1 1 -2" />
                            <Vertex pos="-1 -1 2" />
                            <Vertex pos="-1 -1 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank1" texgens="0 1 0 128 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank1" texgens="0 -1 0 128 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank1" texgens="-1 0 0 384 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank1" texgens="1 0 0 -128 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_grid_blank1" texgens="1 0 0 -128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 384 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="39" owner="0" type="0" pos="0 3 20" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 3 0 0 1 20 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 2" />
                            <Vertex pos="2 1 -2" />
                            <Vertex pos="2 -1 2" />
                            <Vertex pos="2 -1 -2" />
                            <Vertex pos="-2 1 2" />
                            <Vertex pos="-2 1 -2" />
                            <Vertex pos="-2 -1 2" />
                            <Vertex pos="-2 -1 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 128 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 128 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank1" texgens="-1 0 0 -768 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank1" texgens="1 0 0 1024 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_grid_blank1" texgens="1 0 0 1024 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 -768 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="40" owner="0" type="0" pos="-1 8 20" rot="1 0 0 0" scale="" transform="1 0 0 -1 0 1 0 8 0 0 1 20 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 4 2" />
                            <Vertex pos="1 4 -2" />
                            <Vertex pos="1 -4 2" />
                            <Vertex pos="1 -4 -2" />
                            <Vertex pos="-1 4 2" />
                            <Vertex pos="-1 4 -2" />
                            <Vertex pos="-1 -4 2" />
                            <Vertex pos="-1 -4 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank1" texgens="0 1 0 -256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank1" texgens="0 -1 0 512 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank1" texgens="-1 0 0 384 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank1" texgens="1 0 0 -128 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_grid_blank1" texgens="1 0 0 -128 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 384 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="41" owner="0" type="0" pos="4 8 26" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 8 0 0 1 26 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 6 4" />
                            <Vertex pos="6 6 -4" />
                            <Vertex pos="6 -6 4" />
                            <Vertex pos="6 -6 -4" />
                            <Vertex pos="-6 6 4" />
                            <Vertex pos="-6 6 -4" />
                            <Vertex pos="-6 -6 4" />
                            <Vertex pos="-6 -6 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank1" texgens="0 1 0 768 0 0 -1 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank1" texgens="0 -1 0 -512 0 0 -1 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_grid_blank1" texgens="-1 0 0 -256 0 0 -1 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_grid_blank1" texgens="1 0 0 512 0 0 -1 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="" material="bm_tile09_C" texgens="1 0 0 -1024 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank1" texgens="-1 0 0 -256 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="42" owner="0" type="0" pos="-6 8 9.75" rot="1 0 0 0" scale="" transform="1 0 0 -6 0 1 0 8 0 0 1 9.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 0.25" />
                            <Vertex pos="4 2 -0.25" />
                            <Vertex pos="4 -2 0.25" />
                            <Vertex pos="4 -2 -0.25" />
                            <Vertex pos="-4 2 0.25" />
                            <Vertex pos="-4 2 -0.25" />
                            <Vertex pos="-4 -2 0.25" />
                            <Vertex pos="-4 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 -512 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="43" owner="0" type="0" pos="-20 -27 8.25" rot="1 0 0 0" scale="" transform="1 0 0 -20 0 1 0 -27 0 0 1 8.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 2 0.25" />
                            <Vertex pos="6 2 -0.25" />
                            <Vertex pos="6 -2 0.25" />
                            <Vertex pos="6 -2 -0.25" />
                            <Vertex pos="-6 2 0.25" />
                            <Vertex pos="-6 2 -0.25" />
                            <Vertex pos="-6 -2 0.25" />
                            <Vertex pos="-6 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_trim" texgens="0 1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 -512 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="44" owner="0" type="0" pos="-24 -33 8.25" rot="1 0 0 0" scale="" transform="1 0 0 -24 0 1 0 -33 0 0 1 8.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 0.25" />
                            <Vertex pos="2 4 -0.25" />
                            <Vertex pos="2 -4 0.25" />
                            <Vertex pos="2 -4 -0.25" />
                            <Vertex pos="-2 4 0.25" />
                            <Vertex pos="-2 4 -0.25" />
                            <Vertex pos="-2 -4 0.25" />
                            <Vertex pos="-2 -4 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -1920 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 2048 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 -1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 -1536 0 -1 0 2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 1024 0 -1 0 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="45" owner="0" type="0" pos="-24 -28 0.25" rot="1 0 0 0" scale="" transform="1 0 0 -24 0 1 0 -28 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 9 0.25" />
                            <Vertex pos="2 9 -0.25" />
                            <Vertex pos="2 -9 0.25" />
                            <Vertex pos="2 -9 -0.25" />
                            <Vertex pos="-2 9 0.25" />
                            <Vertex pos="-2 9 -0.25" />
                            <Vertex pos="-2 -9 0.25" />
                            <Vertex pos="-2 -9 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -9" album="" material="bm_edge_white" texgens="-1 0 0 1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -9" album="" material="bm_edge_white" texgens="1 0 0 -1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 -1536 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 1024 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="46" owner="0" type="0" pos="4 -23 11.75" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 -23 0 0 1 11.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 0.25" />
                            <Vertex pos="2 4 -0.25" />
                            <Vertex pos="2 -4 0.25" />
                            <Vertex pos="2 -4 -0.25" />
                            <Vertex pos="-2 4 0.25" />
                            <Vertex pos="-2 4 -0.25" />
                            <Vertex pos="-2 -4 0.25" />
                            <Vertex pos="-2 -4 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_trim" texgens="0 -1 0 1024 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 -1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 -1536 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 1024 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="47" owner="0" type="0" pos="5 -14.5 12.75" rot="1 0 0 0" scale="" transform="1 0 0 5 0 1 0 -14.5 0 0 1 12.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 0.25" />
                            <Vertex pos="1.5 2.5 -0.249999" />
                            <Vertex pos="1 -2 0.25" />
                            <Vertex pos="1.5 -2.5 -0.249999" />
                            <Vertex pos="-1 2 0.25" />
                            <Vertex pos="-1.5 2.5 -0.249999" />
                            <Vertex pos="-1 -2 0.25" />
                            <Vertex pos="-1.5 -2.5 -0.249999" />
                        </Vertices>
                        <Face id="0" plane="0.707106 -0 0.707107 -0.883883" album="" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707106 0 0.707107 -0.883883" album="" material="bm_edge_white" texgens="0 -1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 0.707106 0.707108 -1.59099" album="" material="bm_edge_white" texgens="-1 0 0 1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0.707106 0.707107 -1.59099" album="" material="bm_edge_white" texgens="1 0 0 -1280 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 -1280 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.249999" album="" material="bm_grid_blank2" texgens="-1 0 0 0.000976563 0 -1 0 384.003 0 0.1875 0.208333" texRot="0" texScale="0.1875 0.208333" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="48" owner="0" type="0" pos="8 -13.5 13.75" rot="1 0 0 0" scale="" transform="1 0 0 8 0 1 0 -13.5 0 0 1 13.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.999999 0.999999 0.250001" />
                            <Vertex pos="1.5 1.5 -0.25" />
                            <Vertex pos="0.999999 -0.999998 0.250001" />
                            <Vertex pos="1.5 -1.5 -0.25" />
                            <Vertex pos="-1 0.999999 0.250001" />
                            <Vertex pos="-1.5 1.5 -0.25" />
                            <Vertex pos="-1 -0.999998 0.250001" />
                            <Vertex pos="-1.5 -1.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0 0.707107 -0.883883" album="" material="bm_edge_white" texgens="0 1 0 -1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0 0.707106 -0.883885" album="" material="bm_edge_white" texgens="0 -1 0 1792 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 0.707107 0.707107 -0.883883" album="" material="bm_edge_white" texgens="-1 0 0 1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0.707106 0.707107 -0.883882" album="" material="bm_edge_white" texgens="1 0 0 -1280 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.250001" album="" material="bm_tile09_C" texgens="1 0 0 -1280 0 -1 0 1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 -0.00598145 0 -1 0 256 0 0.1875 0.1875" texRot="0" texScale="0.1875 0.1875" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="49" owner="0" type="0" pos="10.5 -11 14.75" rot="1 0 0 0" scale="" transform="1 0 0 10.5 0 1 0 -11 0 0 1 14.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.999998 0.25" />
                            <Vertex pos="1.5 1.5 -0.25" />
                            <Vertex pos="1 -0.999999 0.25" />
                            <Vertex pos="1.5 -1.5 -0.25" />
                            <Vertex pos="-1 0.999998 0.25" />
                            <Vertex pos="-1.5 1.5 -0.25" />
                            <Vertex pos="-1 -0.999999 0.25" />
                            <Vertex pos="-1.5 -1.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0 0.707107 -0.883883" album="" material="bm_edge_white" texgens="0 1 0 -1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0 0.707107 -0.883884" album="" material="bm_edge_white" texgens="0 -1 0 1792 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 0.707105 0.707108 -0.883881" album="" material="bm_edge_white" texgens="-1 0 0 1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0.707106 0.707107 -0.883882" album="" material="bm_edge_white" texgens="1 0 0 -1280 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 -1280 0 -1 0 1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 256.006 0 0.1875 0.1875" texRot="0" texScale="0.1875 0.1875" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="50" owner="0" type="0" pos="8.5 -8 14.75" rot="1 0 0 0" scale="" transform="1 0 0 8.5 0 1 0 -8 0 0 1 14.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.999998 2 0.25" />
                            <Vertex pos="1.5 2.5 -0.25" />
                            <Vertex pos="0.999998 -2 0.25" />
                            <Vertex pos="1.5 -2.5 -0.25" />
                            <Vertex pos="-0.999999 2 0.25" />
                            <Vertex pos="-1.5 2.5 -0.25" />
                            <Vertex pos="-0.999999 -2 0.25" />
                            <Vertex pos="-1.5 -2.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.707105 -0 0.707108 -0.883881" album="" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707106 0 0.707107 -0.883882" album="" material="bm_edge_white" texgens="0 -1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 0.707107 0.707107 -1.59099" album="" material="bm_edge_white" texgens="-1 0 0 1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0.707107 0.707107 -1.59099" album="" material="bm_edge_white" texgens="1 0 0 -1280 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_friction_ice" texgens="1 0 0 2176 0 -1 0 2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 0.0020752 0 -1 0 384.004 0 0.1875 0.208333" texRot="0" texScale="0.1875 0.208333" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="51" owner="0" type="0" pos="5.5 -6 15.75" rot="1 0 0 0" scale="" transform="1 0 0 5.5 0 1 0 -6 0 0 1 15.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 0.25" />
                            <Vertex pos="1.5 1.5 -0.250001" />
                            <Vertex pos="1 -1 0.25" />
                            <Vertex pos="1.5 -1.5 -0.250001" />
                            <Vertex pos="-1 1 0.25" />
                            <Vertex pos="-1.5 1.5 -0.250001" />
                            <Vertex pos="-1 -1 0.25" />
                            <Vertex pos="-1.5 -1.5 -0.250001" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0 0.707106 -0.883884" album="" material="bm_edge_white" texgens="0 1 0 -1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0 0.707106 -0.883884" album="" material="bm_edge_white" texgens="0 -1 0 1792 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 0.707107 0.707106 -0.883884" album="" material="bm_edge_white" texgens="-1 0 0 1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0.707107 0.707106 -0.883884" album="" material="bm_edge_white" texgens="1 0 0 -1280 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_friction_ice" texgens="1 0 0 1408 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.250001" album="" material="bm_grid_blank2" texgens="-1 0 0 -0.000976563 0 -1 0 256 0 0.1875 0.1875" texRot="0" texScale="0.1875 0.1875" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="52" owner="0" type="0" pos="4 -0.999998 16.75" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 -0.999998 0 0 1 16.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 3 0.25" />
                            <Vertex pos="2.5 3.5 -0.25" />
                            <Vertex pos="2 -3 0.25" />
                            <Vertex pos="2.5 -3.5 -0.25" />
                            <Vertex pos="-2 3 0.25" />
                            <Vertex pos="-2.5 3.5 -0.25" />
                            <Vertex pos="-2 -3 0.25" />
                            <Vertex pos="-2.5 -3.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0 0.707107 -1.59099" album="" material="bm_edge_white" texgens="0 1 0 -1152 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0 0.707107 -1.59099" album="" material="bm_edge_white" texgens="0 -1 0 1280 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 0.707107 0.707107 -2.2981" album="" material="bm_edge_white" texgens="-1 0 0 1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0.707107 0.707107 -2.2981" album="" material="bm_edge_white" texgens="1 0 0 -1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 -1536 0 -1 0 1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 -127.999 0 -1 0 512 0 0.208333 0.21875" texRot="0" texScale="0.208333 0.21875" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="53" owner="0" type="0" pos="9 4 16" rot="1 0 0 0" scale="" transform="1 0 0 9 0 1 0 4 0 0 1 16 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 2" />
                            <Vertex pos="1 2 -2" />
                            <Vertex pos="1 -2 2" />
                            <Vertex pos="1 -2 -2" />
                            <Vertex pos="-1 2 2" />
                            <Vertex pos="-1 2 -2" />
                            <Vertex pos="-1 -2 2" />
                            <Vertex pos="-1 -2 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank1" texgens="0 1 0 256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank1" texgens="0 -1 0 0 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 384 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 -128 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_tile09_C" texgens="1 0 0 256 0 -1 0 2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 384 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="54" owner="0" type="0" pos="-5.125 32 7.25" rot="1 0 0 0" scale="" transform="1 0 0 -5.125 0 1 0 32 0 0 1 7.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 2.5 0.25" />
                            <Vertex pos="0.125 2.5 -0.25" />
                            <Vertex pos="0.125 -2.5 0.25" />
                            <Vertex pos="0.125 -2.5 -0.25" />
                            <Vertex pos="-0.125 2.5 0.25" />
                            <Vertex pos="-0.125 2.5 -0.25" />
                            <Vertex pos="-0.125 -2.5 0.25" />
                            <Vertex pos="-0.125 -2.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_trim" texgens="0 1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_trim" texgens="0 -1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2.5" album="" material="bm_trim" texgens="-1 0 0 32 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2.5" album="" material="bm_trim" texgens="1 0 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_trim" texgens="1 0 0 96 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_trim" texgens="-1 0 0 32 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="55" owner="0" type="0" pos="-26 34 9.25" rot="1 0 0 0" scale="" transform="1 0 0 -26 0 1 0 34 0 0 1 9.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 2 0.25" />
                            <Vertex pos="3 2 -0.25" />
                            <Vertex pos="3 -2 0.25" />
                            <Vertex pos="3 -2 -0.25" />
                            <Vertex pos="-3 2 0.25" />
                            <Vertex pos="-3 2 -0.25" />
                            <Vertex pos="-3 -2 0.25" />
                            <Vertex pos="-3 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_edge_white" texgens="0 -1 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 -768 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 640 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="56" owner="0" type="0" pos="-31 35 9.25" rot="1 0 0 0" scale="" transform="1 0 0 -31 0 1 0 35 0 0 1 9.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 0.249999" />
                            <Vertex pos="2 1 -0.25" />
                            <Vertex pos="2 -3 0.249999" />
                            <Vertex pos="2 -3 -0.25" />
                            <Vertex pos="-2 3 0.249999" />
                            <Vertex pos="-2 3 -0.25" />
                            <Vertex pos="-2 -1 0.249999" />
                            <Vertex pos="-2 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 -768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.447214 0.894427 -0 -1.78885" album="" material="bm_edge_white" texgens="-1 0 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.447214 -0.894427 -0 -1.78885" album="" material="bm_edge_white" texgens="1 0 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 0 1 -0.249999" album="" material="bm_tile09_C" texgens="1 0 0 512 -0.5 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 256 -0.5 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="57" owner="0" type="0" pos="-36 36 9.25" rot="1 0 0 0" scale="" transform="1 0 0 -36 0 1 0 36 0 0 1 9.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 2 0.25" />
                            <Vertex pos="3 2 -0.25" />
                            <Vertex pos="3 -2 0.25" />
                            <Vertex pos="3 -2 -0.25" />
                            <Vertex pos="-3 2 0.25" />
                            <Vertex pos="-3 2 -0.25" />
                            <Vertex pos="-3 -2 0.25" />
                            <Vertex pos="-3 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 1152 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_edge_white" texgens="0 -1 0 -1024 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 -768 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 640 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="58" owner="0" type="0" pos="-15 58 -1.25" rot="1 0 0 0" scale="" transform="1 0 0 -15 0 1 0 58 0 0 1 -1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 0.25" />
                            <Vertex pos="4 2 -0.25" />
                            <Vertex pos="4 -2 0.25" />
                            <Vertex pos="4 -2 -0.25" />
                            <Vertex pos="-4 2 0.25" />
                            <Vertex pos="-4 2 -0.25" />
                            <Vertex pos="-4 -2 0.25" />
                            <Vertex pos="-4 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_edge_white" texgens="0 -1 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 -512 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="59" owner="0" type="0" pos="-9 56 -1.25" rot="1 0 0 0" scale="" transform="1 0 0 -9 0 1 0 56 0 0 1 -1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 0.25" />
                            <Vertex pos="2 4 -0.25" />
                            <Vertex pos="2 -4 0.25" />
                            <Vertex pos="2 -4 -0.25" />
                            <Vertex pos="-2 4 0.25" />
                            <Vertex pos="-2 4 -0.25" />
                            <Vertex pos="-2 -4 0.25" />
                            <Vertex pos="-2 -4 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 1152 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 -1024 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 -1024 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 768 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="60" owner="0" type="0" pos="-17 31.875 -4.75" rot="1 0 0 0" scale="" transform="1 0 0 -17 0 1 0 31.875 0 0 1 -4.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.5 0.125 0.25" />
                            <Vertex pos="2.5 0.125 -0.25" />
                            <Vertex pos="2.5 -0.125 0.25" />
                            <Vertex pos="2.5 -0.125 -0.25" />
                            <Vertex pos="-2.5 0.125 0.25" />
                            <Vertex pos="-2.5 0.125 -0.25" />
                            <Vertex pos="-2.5 -0.125 0.25" />
                            <Vertex pos="-2.5 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2.5" album="" material="bm_trim" texgens="0 1 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2.5" album="" material="bm_trim" texgens="0 -1 0 32 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_trim" texgens="-1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_trim" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_trim" texgens="1 0 0 -384 0 -1 0 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_trim" texgens="-1 0 0 512 0 -1 0 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="61" owner="0" type="0" pos="-17 28.625 -5.25" rot="1 0 0 0" scale="" transform="1 0 0 -17 0 1 0 28.625 0 0 1 -5.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.5 0.125 0.25" />
                            <Vertex pos="2.5 0.125 -0.25" />
                            <Vertex pos="2.5 -0.125 0.25" />
                            <Vertex pos="2.5 -0.125 -0.25" />
                            <Vertex pos="-2.5 0.125 0.25" />
                            <Vertex pos="-2.5 0.125 -0.25" />
                            <Vertex pos="-2.5 -0.125 0.25" />
                            <Vertex pos="-2.5 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2.5" album="" material="bm_trim" texgens="0 1 0 32 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2.5" album="" material="bm_trim" texgens="0 -1 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_trim" texgens="-1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_trim" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_trim" texgens="1 0 0 -384 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_trim" texgens="-1 0 0 512 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="62" owner="0" type="0" pos="-17 1 2.75" rot="1 0 0 0" scale="" transform="1 0 0 -17 0 1 0 1 0 0 1 2.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 0.25" />
                            <Vertex pos="2 4 -0.25" />
                            <Vertex pos="2 -4 0.25" />
                            <Vertex pos="2 -4 -0.25" />
                            <Vertex pos="-2 4 0.25" />
                            <Vertex pos="-2 4 -0.25" />
                            <Vertex pos="-2 -4 0.25" />
                            <Vertex pos="-2 -4 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 0 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 256 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="63" owner="1" type="999" pos="3 -16 0.75" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 -16 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 0.25" />
                            <Vertex pos="1 1 -0.25" />
                            <Vertex pos="1 -1 0.25" />
                            <Vertex pos="1 -1 -0.25" />
                            <Vertex pos="-1 1 0.25" />
                            <Vertex pos="-1 1 -0.25" />
                            <Vertex pos="-1 -1 0.25" />
                            <Vertex pos="-1 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_mp2" texgens="0 1 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_mp2" texgens="0 -1 0 256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_mp2" texgens="-1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_mp2" texgens="1 0 0 256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile06_D" texgens="1 0 0 256 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="64" owner="5" type="999" pos="1 -19 1.25" rot="1 0 0 0" scale="" transform="1 0 0 1 0 1 0 -19 0 0 1 1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 0.25" />
                            <Vertex pos="1 1 -0.25" />
                            <Vertex pos="1 -1 0.25" />
                            <Vertex pos="1 -1 -0.25" />
                            <Vertex pos="-1 1 0.25" />
                            <Vertex pos="-1 1 -0.25" />
                            <Vertex pos="-1 -1 0.25" />
                            <Vertex pos="-1 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_mp2" texgens="0 1 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_mp2" texgens="0 -1 0 256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_mp2" texgens="-1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_mp2" texgens="1 0 0 256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile06_D" texgens="1 0 0 256 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="65" owner="15" type="999" pos="2 3 4.75" rot="1 0 0 0" scale="" transform="1 0 0 2 0 1 0 3 0 0 1 4.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 0.25" />
                            <Vertex pos="1 1 -0.25" />
                            <Vertex pos="1 -1 0.25" />
                            <Vertex pos="1 -1 -0.25" />
                            <Vertex pos="-1 1 0.25" />
                            <Vertex pos="-1 1 -0.25" />
                            <Vertex pos="-1 -1 0.25" />
                            <Vertex pos="-1 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_mp2" texgens="0 1 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_mp2" texgens="0 -1 0 256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_mp2" texgens="-1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_mp2" texgens="1 0 0 256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile06_D" texgens="1 0 0 256 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="66" owner="19" type="999" pos="6 1 5.25" rot="1 0 0 0" scale="" transform="1 0 0 6 0 1 0 1 0 0 1 5.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 0.25" />
                            <Vertex pos="1 1 -0.25" />
                            <Vertex pos="1 -1 0.25" />
                            <Vertex pos="1 -1 -0.25" />
                            <Vertex pos="-1 1 0.25" />
                            <Vertex pos="-1 1 -0.25" />
                            <Vertex pos="-1 -1 0.25" />
                            <Vertex pos="-1 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_mp2" texgens="0 1 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_mp2" texgens="0 -1 0 256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_mp2" texgens="-1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_mp2" texgens="1 0 0 256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile06_D" texgens="1 0 0 256 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="67" owner="9" type="999" pos="-19 25 4.5" rot="1 0 0 0" scale="" transform="1 0 0 -19 0 1 0 25 0 0 1 4.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12 1 -1.5" />
                            <Vertex pos="12 1 -2" />
                            <Vertex pos="12 -0.999998 -1.5" />
                            <Vertex pos="12 -0.999998 -2" />
                            <Vertex pos="-12 1 2" />
                            <Vertex pos="-12 1 1.5" />
                            <Vertex pos="-12 -0.999998 2" />
                            <Vertex pos="-12 -0.999998 1.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -12" album="" material="bm_edge_mp2" texgens="0 1 0 -128 0 0 -1 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -12" album="" material="bm_edge_mp2" texgens="0 -1 0 256 0 0 -1 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_mp2" texgens="-1 0 0 -2944 -0.145833 0 -1 64.001 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.999998" album="" material="bm_edge_mp2" texgens="1 0 0 -2944 -0.145833 0 -1 64.001 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.144307 0 0.989533 -0.247383" album="" material="bm_tile06_D" texgens="1 0 0 3072 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.144307 0 -0.989533 -0.247383" album="" material="bm_grid_blank2" texgens="-1 0 0 -1280 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="68" owner="23" type="999" pos="11 8 5.75" rot="1 0 0 0" scale="" transform="1 0 0 11 0 1 0 8 0 0 1 5.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 0.25" />
                            <Vertex pos="1 2 -0.25" />
                            <Vertex pos="1 -2 0.25" />
                            <Vertex pos="1 -2 -0.25" />
                            <Vertex pos="-1 2 0.25" />
                            <Vertex pos="-1 2 -0.25" />
                            <Vertex pos="-1 -2 0.25" />
                            <Vertex pos="-1 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_mp1" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_mp1" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_mp1" texgens="-1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_mp1" texgens="1 0 0 256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile07_D" texgens="1 0 0 256 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 128 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="69" owner="33" type="999" pos="-7.5 33 6.75" rot="1 0 0 0" scale="" transform="1 0 0 -7.5 0 1 0 33 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 0.25" />
                            <Vertex pos="1 1 -0.25" />
                            <Vertex pos="1 -1 0.25" />
                            <Vertex pos="1 -1 -0.25" />
                            <Vertex pos="-1 1 0.25" />
                            <Vertex pos="-1 1 -0.25" />
                            <Vertex pos="-1 -1 0.25" />
                            <Vertex pos="-1 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_mp2" texgens="0 1 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_mp2" texgens="0 -1 0 256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_mp2" texgens="-1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_mp2" texgens="1 0 0 256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile06_D" texgens="1 0 0 256 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="70" owner="41" type="999" pos="-20.5 33 8.75" rot="1 0 0 0" scale="" transform="1 0 0 -20.5 0 1 0 33 0 0 1 8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 0.25" />
                            <Vertex pos="1 1 -0.25" />
                            <Vertex pos="1 -1 0.25" />
                            <Vertex pos="1 -1 -0.25" />
                            <Vertex pos="-1 1 0.25" />
                            <Vertex pos="-1 1 -0.25" />
                            <Vertex pos="-1 -1 0.25" />
                            <Vertex pos="-1 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_mp2" texgens="0 1 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_mp2" texgens="0 -1 0 256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_mp2" texgens="-1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_mp2" texgens="1 0 0 256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile06_D" texgens="1 0 0 256 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="71" owner="37" type="999" pos="-17 31 8.25" rot="1 0 0 0" scale="" transform="1 0 0 -17 0 1 0 31 0 0 1 8.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 0.25" />
                            <Vertex pos="1 1 -0.25" />
                            <Vertex pos="1 -1 0.25" />
                            <Vertex pos="1 -1 -0.25" />
                            <Vertex pos="-1 1 0.25" />
                            <Vertex pos="-1 1 -0.25" />
                            <Vertex pos="-1 -1 0.25" />
                            <Vertex pos="-1 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_mp2" texgens="0 1 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_mp2" texgens="0 -1 0 256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_mp2" texgens="-1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_mp2" texgens="1 0 0 256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile06_D" texgens="1 0 0 256 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="72" owner="37" type="999" pos="-14 31 7.75" rot="1 0 0 0" scale="" transform="1 0 0 -14 0 1 0 31 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 -0.25" />
                            <Vertex pos="2 1 -0.75" />
                            <Vertex pos="2 -1 -0.25" />
                            <Vertex pos="2 -1 -0.75" />
                            <Vertex pos="-2 1 0.75" />
                            <Vertex pos="-2 1 0.25" />
                            <Vertex pos="-2 -1 0.75" />
                            <Vertex pos="-2 -1 0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_mp2" texgens="0 1 0 -128 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_mp2" texgens="0 -1 0 256 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_mp2" texgens="-1 0 0 512 -0.25 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_mp2" texgens="1 0 0 512 -0.25 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970143 -0.242536" album="" material="bm_tile06_D" texgens="1 0 0 512 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970143 -0.242536" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="73" owner="37" type="999" pos="-11 31 7.25" rot="1 0 0 0" scale="" transform="1 0 0 -11 0 1 0 31 0 0 1 7.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 0.25" />
                            <Vertex pos="1 1 -0.25" />
                            <Vertex pos="1 -1 0.25" />
                            <Vertex pos="1 -1 -0.25" />
                            <Vertex pos="-1 1 0.25" />
                            <Vertex pos="-1 1 -0.25" />
                            <Vertex pos="-1 -1 0.25" />
                            <Vertex pos="-1 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_mp2" texgens="0 1 0 -128 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_mp2" texgens="0 -1 0 256 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_mp2" texgens="-1 0 0 -128 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_mp2" texgens="1 0 0 256 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile06_D" texgens="1 0 0 256 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="74" owner="27" type="999" pos="-6 -26 10" rot="1 0 0 0" scale="" transform="1 0 0 -6 0 1 0 -26 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="8 1 2" />
                            <Vertex pos="8 1 1.5" />
                            <Vertex pos="8 -1 2" />
                            <Vertex pos="8 -1 1.5" />
                            <Vertex pos="-8 1 -1.5" />
                            <Vertex pos="-8 1 -2" />
                            <Vertex pos="-8 -1 -1.5" />
                            <Vertex pos="-8 -1 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -8" album="" material="bm_edge_mp2" texgens="0 1 0 -128 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -8" album="" material="bm_edge_mp2" texgens="0 -1 0 256 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_mp2" texgens="-1 0 0 -1920 0.21875 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_mp2" texgens="1 0 0 -1920 0.21875 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.213697 0 0.9769 -0.244225" album="" material="bm_tile06_D" texgens="1 0 0 2048 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.213697 0 -0.9769 -0.244225" album="" material="bm_grid_blank2" texgens="-1 0 0 -768 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="75" owner="0" type="0" pos="1 5 32" rot="1 0 0 0" scale="" transform="1 0 0 1 0 1 0 5 0 0 1 32 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 2" />
                            <Vertex pos="1 1 -2" />
                            <Vertex pos="1 -1 2" />
                            <Vertex pos="1 -1 -2" />
                            <Vertex pos="-1 1 2" />
                            <Vertex pos="-1 1 -2" />
                            <Vertex pos="-1 -1 2" />
                            <Vertex pos="-1 -1 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank1" texgens="0 1 0 128 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank1" texgens="0 -1 0 128 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank1" texgens="-1 0 0 -896 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank1" texgens="1 0 0 1152 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_grid_blank1" texgens="1 0 0 1152 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 -896 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="76" owner="0" type="0" pos="7 5 32" rot="1 0 0 0" scale="" transform="1 0 0 7 0 1 0 5 0 0 1 32 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 2" />
                            <Vertex pos="1 1 -2" />
                            <Vertex pos="1 -1 2" />
                            <Vertex pos="1 -1 -2" />
                            <Vertex pos="-1 1 2" />
                            <Vertex pos="-1 1 -2" />
                            <Vertex pos="-1 -1 2" />
                            <Vertex pos="-1 -1 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank1" texgens="0 1 0 128 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank1" texgens="0 -1 0 128 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank1" texgens="-1 0 0 -896 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank1" texgens="1 0 0 1152 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_grid_blank1" texgens="1 0 0 1152 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 -896 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="77" owner="0" type="0" pos="1 11 32" rot="1 0 0 0" scale="" transform="1 0 0 1 0 1 0 11 0 0 1 32 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 2" />
                            <Vertex pos="1 1 -2" />
                            <Vertex pos="1 -1 2" />
                            <Vertex pos="1 -1 -2" />
                            <Vertex pos="-1 1 2" />
                            <Vertex pos="-1 1 -2" />
                            <Vertex pos="-1 -1 2" />
                            <Vertex pos="-1 -1 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank1" texgens="0 1 0 128 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank1" texgens="0 -1 0 128 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank1" texgens="-1 0 0 -896 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank1" texgens="1 0 0 1152 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_grid_blank1" texgens="1 0 0 1152 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 -896 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="78" owner="0" type="0" pos="7 11 32" rot="1 0 0 0" scale="" transform="1 0 0 7 0 1 0 11 0 0 1 32 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 2" />
                            <Vertex pos="1 1 -2" />
                            <Vertex pos="1 -1 2" />
                            <Vertex pos="1 -1 -2" />
                            <Vertex pos="-1 1 2" />
                            <Vertex pos="-1 1 -2" />
                            <Vertex pos="-1 -1 2" />
                            <Vertex pos="-1 -1 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank1" texgens="0 1 0 128 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank1" texgens="0 -1 0 128 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank1" texgens="-1 0 0 -896 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank1" texgens="1 0 0 1152 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_grid_blank1" texgens="1 0 0 1152 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 -896 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="79" owner="0" type="0" pos="4 8 36" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 8 0 0 1 36 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank1" texgens="0 1 0 -256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank1" texgens="0 -1 0 512 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank1" texgens="-1 0 0 -512 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank1" texgens="1 0 0 768 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_tile09_C" texgens="1 0 0 -512 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 -512 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="80" owner="0" type="0" pos="-24 -31 10.75" rot="1 0 0 0" scale="" transform="1 0 0 -24 0 1 0 -31 0 0 1 10.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 6 0.25" />
                            <Vertex pos="2 6 -0.25" />
                            <Vertex pos="2 -6 0.25" />
                            <Vertex pos="2 -6 -0.25" />
                            <Vertex pos="-2 6 0.25" />
                            <Vertex pos="-2 6 -0.25" />
                            <Vertex pos="-2 -6 0.25" />
                            <Vertex pos="-2 -6 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_edge_white" texgens="-1 0 0 1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 -1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_grid_blank2" texgens="1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_tile09_C" texgens="-1 0 0 0 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="81" owner="0" type="0" pos="-2.25 -0.75 0.25" rot="1 0 0 0" scale="" transform="1 0 0 -2.25 0 1 0 -0.75 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 3.25 0.25" />
                            <Vertex pos="0.25 3.25 -0.25" />
                            <Vertex pos="0.25 -3.25 0.25" />
                            <Vertex pos="0.25 -3.25 -0.25" />
                            <Vertex pos="-0.25 3.25 0.25" />
                            <Vertex pos="-0.25 3.25 -0.25" />
                            <Vertex pos="-0.25 -3.25 0.25" />
                            <Vertex pos="-0.25 -3.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -704 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 832 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="82" owner="0" type="0" pos="2.25 -1 0.25" rot="1 0 0 0" scale="" transform="1 0 0 2.25 0 1 0 -1 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 3 0.25" />
                            <Vertex pos="0.25 3 -0.25" />
                            <Vertex pos="0.25 -3 0.25" />
                            <Vertex pos="0.25 -3 -0.25" />
                            <Vertex pos="-0.25 3 0.25" />
                            <Vertex pos="-0.25 3 -0.25" />
                            <Vertex pos="-0.25 -3 0.25" />
                            <Vertex pos="-0.25 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="83" owner="0" type="0" pos="3.25 -6 0.25" rot="1 0 0 0" scale="" transform="1 0 0 3.25 0 1 0 -6 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.75 2 0.25" />
                            <Vertex pos="-0.75 2 -0.25" />
                            <Vertex pos="1.25 -2 0.25" />
                            <Vertex pos="1.25 -2 -0.25" />
                            <Vertex pos="-1.25 2 0.25" />
                            <Vertex pos="-1.25 2 -0.25" />
                            <Vertex pos="0.75 -2 0.25" />
                            <Vertex pos="0.75 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.894427 0.447214 0 -0.223607" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.894427 -0.447214 0 -0.223607" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 320 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -192 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0.5 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 -0.5 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="84" owner="0" type="0" pos="-1.25 -6 0.25" rot="1 0 0 0" scale="" transform="1 0 0 -1.25 0 1 0 -6 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.75 2 0.25" />
                            <Vertex pos="-0.75 2 -0.25" />
                            <Vertex pos="1.25 -2 0.25" />
                            <Vertex pos="1.25 -2 -0.25" />
                            <Vertex pos="-1.25 2 0.25" />
                            <Vertex pos="-1.25 2 -0.25" />
                            <Vertex pos="0.75 -2 0.25" />
                            <Vertex pos="0.75 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.894427 0.447214 0 -0.223607" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.894427 -0.447214 0 -0.223607" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 320 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -192 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0.5 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 -0.5 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="85" owner="0" type="0" pos="4.25 -11 0.25" rot="1 0 0 0" scale="" transform="1 0 0 4.25 0 1 0 -11 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 3 0.25" />
                            <Vertex pos="0.25 3 -0.25" />
                            <Vertex pos="0.25 -3 0.25" />
                            <Vertex pos="0.25 -3 -0.25" />
                            <Vertex pos="-0.25 3 0.25" />
                            <Vertex pos="-0.25 3 -0.25" />
                            <Vertex pos="-0.25 -3 0.25" />
                            <Vertex pos="-0.25 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="86" owner="0" type="0" pos="-0.25 -11 0.25" rot="1 0 0 0" scale="" transform="1 0 0 -0.25 0 1 0 -11 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 3 0.25" />
                            <Vertex pos="0.25 3 -0.25" />
                            <Vertex pos="0.25 -3 0.25" />
                            <Vertex pos="0.25 -3 -0.25" />
                            <Vertex pos="-0.25 3 0.25" />
                            <Vertex pos="-0.25 3 -0.25" />
                            <Vertex pos="-0.25 -3 0.25" />
                            <Vertex pos="-0.25 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="87" owner="0" type="0" pos="2 -14.125 0.25" rot="1 0 0 0" scale="" transform="1 0 0 2 0 1 0 -14.125 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.5 0.125 0.25" />
                            <Vertex pos="2.5 0.125 -0.25" />
                            <Vertex pos="2.5 -0.125 0.25" />
                            <Vertex pos="2.5 -0.125 -0.25" />
                            <Vertex pos="-2.5 0.125 0.25" />
                            <Vertex pos="-2.5 0.125 -0.25" />
                            <Vertex pos="-2.5 -0.125 0.25" />
                            <Vertex pos="-2.5 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2.5" album="" material="bm_trim" texgens="0 1 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2.5" album="" material="bm_trim" texgens="0 -1 0 32 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_trim" texgens="-1 0 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_trim" texgens="1 0 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_trim" texgens="1 0 0 640 0 -1 0 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_trim" texgens="-1 0 0 -512 0 -1 0 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="88" owner="0" type="0" pos="0 -20.875 1.75" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -20.875 0 0 1 1.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.5 0.125 0.25" />
                            <Vertex pos="2.5 0.125 -0.25" />
                            <Vertex pos="2.5 -0.125 0.25" />
                            <Vertex pos="2.5 -0.125 -0.25" />
                            <Vertex pos="-2.5 0.125 0.25" />
                            <Vertex pos="-2.5 0.125 -0.25" />
                            <Vertex pos="-2.5 -0.125 0.25" />
                            <Vertex pos="-2.5 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2.5" album="" material="bm_trim" texgens="0 1 0 32 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2.5" album="" material="bm_trim" texgens="0 -1 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_trim" texgens="-1 0 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_trim" texgens="1 0 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_trim" texgens="1 0 0 640 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_trim" texgens="-1 0 0 -512 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="89" owner="0" type="0" pos="2.25 -25.25 1.75" rot="1 0 0 0" scale="" transform="1 0 0 2.25 0 1 0 -25.25 0 0 1 1.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4.25 0.25" />
                            <Vertex pos="0.25 4.25 -0.25" />
                            <Vertex pos="0.25 -4.25 0.25" />
                            <Vertex pos="0.25 -4.25 -0.25" />
                            <Vertex pos="-0.25 4.25 0.25" />
                            <Vertex pos="-0.25 4.25 -0.25" />
                            <Vertex pos="-0.25 -4.25 0.25" />
                            <Vertex pos="-0.25 -4.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -960 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 1088 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 1088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 1088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="90" owner="0" type="0" pos="-2.25 -22.75 1.75" rot="1 0 0 0" scale="" transform="1 0 0 -2.25 0 1 0 -22.75 0 0 1 1.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1.75 0.25" />
                            <Vertex pos="0.25 1.75 -0.25" />
                            <Vertex pos="0.25 -1.75 0.25" />
                            <Vertex pos="0.25 -1.75 -0.25" />
                            <Vertex pos="-0.25 1.75 0.25" />
                            <Vertex pos="-0.25 1.75 -0.25" />
                            <Vertex pos="-0.25 -1.75 0.25" />
                            <Vertex pos="-0.25 -1.75 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -320 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 448 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1.75" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.75" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="91" owner="0" type="0" pos="-4 -24.75 1.75" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 -24.75 0 0 1 1.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.25 0.25" />
                            <Vertex pos="2 0.25 -0.25" />
                            <Vertex pos="2 -0.25 0.25" />
                            <Vertex pos="2 -0.25 -0.25" />
                            <Vertex pos="-2 0.25 0.25" />
                            <Vertex pos="-2 0.25 -0.25" />
                            <Vertex pos="-2 -0.25 0.25" />
                            <Vertex pos="-2 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -384 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 512 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="92" owner="0" type="0" pos="-2 -29.25 1.75" rot="1 0 0 0" scale="" transform="1 0 0 -2 0 1 0 -29.25 0 0 1 1.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.25 0.25" />
                            <Vertex pos="4 0.25 -0.25" />
                            <Vertex pos="4 -0.25 0.25" />
                            <Vertex pos="4 -0.25 -0.25" />
                            <Vertex pos="-4 0.25 0.25" />
                            <Vertex pos="-4 0.25 -0.25" />
                            <Vertex pos="-4 -0.25 0.25" />
                            <Vertex pos="-4 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 128 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 0 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="93" owner="0" type="0" pos="-6.5 -24.75 1.875" rot="1 0 0 0" scale="" transform="1 0 0 -6.5 0 1 0 -24.75 0 0 1 1.875 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.25 0.125" />
                            <Vertex pos="0.5 0.25 -0.375" />
                            <Vertex pos="0.5 -0.25 0.125" />
                            <Vertex pos="0.5 -0.25 -0.375" />
                            <Vertex pos="-0.5 0.25 0.375" />
                            <Vertex pos="-0.5 0.25 -0.125" />
                            <Vertex pos="-0.5 -0.25 0.375" />
                            <Vertex pos="-0.5 -0.25 -0.125" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 0 -0.25 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970143 -0.242536" album="" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970143 -0.242536" album="" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="94" owner="0" type="0" pos="-9.5 -24.75 3.125" rot="1 0 0 0" scale="" transform="1 0 0 -9.5 0 1 0 -24.75 0 0 1 3.125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.25 0.125" />
                            <Vertex pos="0.5 0.25 -0.375" />
                            <Vertex pos="0.5 -0.25 0.125" />
                            <Vertex pos="0.5 -0.25 -0.375" />
                            <Vertex pos="-0.5 0.25 0.375" />
                            <Vertex pos="-0.5 0.25 -0.125" />
                            <Vertex pos="-0.5 -0.25 0.375" />
                            <Vertex pos="-0.5 -0.25 -0.125" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 0 -0.25 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970143 -0.242536" album="" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970143 -0.242536" album="" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="95" owner="0" type="0" pos="-6.5 -29.25 1.875" rot="1 0 0 0" scale="" transform="1 0 0 -6.5 0 1 0 -29.25 0 0 1 1.875 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.25 0.125" />
                            <Vertex pos="0.5 0.25 -0.375" />
                            <Vertex pos="0.5 -0.25 0.125" />
                            <Vertex pos="0.5 -0.25 -0.375" />
                            <Vertex pos="-0.5 0.25 0.375" />
                            <Vertex pos="-0.5 0.25 -0.125" />
                            <Vertex pos="-0.5 -0.25 0.375" />
                            <Vertex pos="-0.5 -0.25 -0.125" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 0 -0.25 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970143 -0.242536" album="" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970143 -0.242536" album="" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="96" owner="0" type="0" pos="-9.5 -29.25 3.125" rot="1 0 0 0" scale="" transform="1 0 0 -9.5 0 1 0 -29.25 0 0 1 3.125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.25 0.125" />
                            <Vertex pos="0.5 0.25 -0.375" />
                            <Vertex pos="0.5 -0.25 0.125" />
                            <Vertex pos="0.5 -0.25 -0.375" />
                            <Vertex pos="-0.5 0.25 0.375" />
                            <Vertex pos="-0.5 0.25 -0.125" />
                            <Vertex pos="-0.5 -0.25 0.375" />
                            <Vertex pos="-0.5 -0.25 -0.125" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 0 -0.25 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970143 -0.242536" album="" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970143 -0.242536" album="" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="97" owner="0" type="0" pos="-8 -24.75 2.5" rot="1 0 0 0" scale="" transform="1 0 0 -8 0 1 0 -24.75 0 0 1 2.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.25 -0.25" />
                            <Vertex pos="1 0.25 -0.75" />
                            <Vertex pos="1 -0.250002 -0.25" />
                            <Vertex pos="1 -0.250002 -0.75" />
                            <Vertex pos="-1 0.25 0.75" />
                            <Vertex pos="-1 0.25 0.25" />
                            <Vertex pos="-1 -0.250002 0.75" />
                            <Vertex pos="-1 -0.250002 0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 256 -0.5 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.250002" album="" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.447214 0 0.894427 -0.223607" album="" material="bm_edge_white" texgens="1 0 0 -128 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.447214 0 -0.894427 -0.223607" album="" material="bm_edge_white" texgens="-1 0 0 256 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="98" owner="0" type="0" pos="-8 -29.25 2.5" rot="1 0 0 0" scale="" transform="1 0 0 -8 0 1 0 -29.25 0 0 1 2.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.249998 -0.25" />
                            <Vertex pos="1 0.249998 -0.75" />
                            <Vertex pos="1 -0.25 -0.25" />
                            <Vertex pos="1 -0.25 -0.75" />
                            <Vertex pos="-1 0.249998 0.75" />
                            <Vertex pos="-1 0.249998 0.25" />
                            <Vertex pos="-1 -0.25 0.75" />
                            <Vertex pos="-1 -0.25 0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.249998" album="" material="bm_edge_white" texgens="-1 0 0 256 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 256 -0.5 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.447214 0 0.894427 -0.223607" album="" material="bm_edge_white" texgens="1 0 0 -128 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.447214 0 -0.894427 -0.223607" album="" material="bm_edge_white" texgens="-1 0 0 256 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="99" owner="0" type="0" pos="-18 -29.25 3.25" rot="1 0 0 0" scale="" transform="1 0 0 -18 0 1 0 -29.25 0 0 1 3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="8 0.25 0.25" />
                            <Vertex pos="8 0.25 -0.25" />
                            <Vertex pos="8 -0.25 0.25" />
                            <Vertex pos="8 -0.25 -0.25" />
                            <Vertex pos="-8 0.25 0.25" />
                            <Vertex pos="-8 0.25 -0.25" />
                            <Vertex pos="-8 -0.25 0.25" />
                            <Vertex pos="-8 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -8" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -8" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1024 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -896 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1024 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="100" owner="0" type="0" pos="-29.75 -24.75 3.25" rot="1 0 0 0" scale="" transform="1 0 0 -29.75 0 1 0 -24.75 0 0 1 3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="7.75 0.25 0.25" />
                            <Vertex pos="7.75 0.25 -0.25" />
                            <Vertex pos="7.75 -0.25 0.25" />
                            <Vertex pos="7.75 -0.25 -0.25" />
                            <Vertex pos="-7.75 0.25 0.25" />
                            <Vertex pos="-7.75 0.25 -0.25" />
                            <Vertex pos="-7.75 -0.25 0.25" />
                            <Vertex pos="-7.75 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -7.75" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -7.75" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1088 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -960 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -960 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1088 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="101" owner="0" type="0" pos="-14 -24.75 3.25" rot="1 0 0 0" scale="" transform="1 0 0 -14 0 1 0 -24.75 0 0 1 3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.25 0.25" />
                            <Vertex pos="4 0.25 -0.25" />
                            <Vertex pos="4 -0.25 0.25" />
                            <Vertex pos="4 -0.25 -0.25" />
                            <Vertex pos="-4 0.25 0.25" />
                            <Vertex pos="-4 0.25 -0.25" />
                            <Vertex pos="-4 -0.25 0.25" />
                            <Vertex pos="-4 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 128 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 0 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="102" owner="0" type="0" pos="-36.25 -29.25 3.25" rot="1 0 0 0" scale="" transform="1 0 0 -36.25 0 1 0 -29.25 0 0 1 3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6.25 0.25 0.25" />
                            <Vertex pos="6.25 0.25 -0.25" />
                            <Vertex pos="6.25 -0.25 0.25" />
                            <Vertex pos="6.25 -0.25 -0.25" />
                            <Vertex pos="-6.25 0.25 0.25" />
                            <Vertex pos="-6.25 0.25 -0.25" />
                            <Vertex pos="-6.25 -0.25 0.25" />
                            <Vertex pos="-6.25 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6.25" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6.25" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 576 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -448 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -448 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 576 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="103" owner="0" type="0" pos="-37.75 -23 3.25" rot="1 0 0 0" scale="" transform="1 0 0 -37.75 0 1 0 -23 0 0 1 3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 0.25" />
                            <Vertex pos="0.25 2 -0.25" />
                            <Vertex pos="0.25 -2 0.25" />
                            <Vertex pos="0.25 -2 -0.25" />
                            <Vertex pos="-0.25 2 0.25" />
                            <Vertex pos="-0.25 2 -0.25" />
                            <Vertex pos="-0.25 -2 0.25" />
                            <Vertex pos="-0.25 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="104" owner="0" type="0" pos="-42.25 -25 3.25" rot="1 0 0 0" scale="" transform="1 0 0 -42.25 0 1 0 -25 0 0 1 3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4 0.25" />
                            <Vertex pos="0.25 4 -0.25" />
                            <Vertex pos="0.25 -4 0.25" />
                            <Vertex pos="0.25 -4 -0.25" />
                            <Vertex pos="-0.25 4 0.25" />
                            <Vertex pos="-0.25 4 -0.25" />
                            <Vertex pos="-0.25 -4 0.25" />
                            <Vertex pos="-0.25 -4 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 1024 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="105" owner="0" type="0" pos="-37.75 -19 7.75" rot="1 0 0 0" scale="" transform="1 0 0 -37.75 0 1 0 -19 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 0.25" />
                            <Vertex pos="0.25 2 -0.25" />
                            <Vertex pos="0.25 -2 0.25" />
                            <Vertex pos="0.25 -2 -0.25" />
                            <Vertex pos="-0.25 2 0.25" />
                            <Vertex pos="-0.25 2 -0.25" />
                            <Vertex pos="-0.25 -2 0.25" />
                            <Vertex pos="-0.25 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="106" owner="0" type="0" pos="-42.25 -19 7.75" rot="1 0 0 0" scale="" transform="1 0 0 -42.25 0 1 0 -19 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 0.25" />
                            <Vertex pos="0.25 2 -0.25" />
                            <Vertex pos="0.25 -2 0.25" />
                            <Vertex pos="0.25 -2 -0.25" />
                            <Vertex pos="-0.25 2 0.25" />
                            <Vertex pos="-0.25 2 -0.25" />
                            <Vertex pos="-0.25 -2 0.25" />
                            <Vertex pos="-0.25 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="107" owner="0" type="0" pos="-40 -20.75 3.25" rot="1 0 0 0" scale="" transform="1 0 0 -40 0 1 0 -20.75 0 0 1 3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.5 0.25 0.25" />
                            <Vertex pos="2.5 0.25 -0.25" />
                            <Vertex pos="2.5 -0.25 0.25" />
                            <Vertex pos="2.5 -0.25 -0.25" />
                            <Vertex pos="-2.5 0.25 0.25" />
                            <Vertex pos="-2.5 0.25 -0.25" />
                            <Vertex pos="-2.5 -0.25 0.25" />
                            <Vertex pos="-2.5 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2.5" album="" material="bm_edge_white" texgens="0 1 0 -832 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2.5" album="" material="bm_edge_white" texgens="0 -1 0 960 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 640 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -512 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="108" owner="0" type="0" pos="-41 -20.75 5.5" rot="1 0 0 0" scale="" transform="1 0 0 -41 0 1 0 -20.75 0 0 1 5.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.25 2" />
                            <Vertex pos="1 0.25 -2" />
                            <Vertex pos="1 -0.25 2" />
                            <Vertex pos="1 -0.25 -2" />
                            <Vertex pos="-1 0.25 2" />
                            <Vertex pos="-1 0.25 -2" />
                            <Vertex pos="-1 -0.25 2" />
                            <Vertex pos="-1 -0.25 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -832 0 0 -1 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 960 0 0 -1 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 128 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_grid_blank2" texgens="1 0 0 128 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_edge_white" texgens="1 0 0 256 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_edge_white" texgens="-1 0 0 -128 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="109" owner="0" type="0" pos="-39 -20.75 5.5" rot="1 0 0 0" scale="" transform="1 0 0 -39 0 1 0 -20.75 0 0 1 5.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.25 2" />
                            <Vertex pos="1 0.25 -2" />
                            <Vertex pos="1 -0.25 2" />
                            <Vertex pos="1 -0.25 -2" />
                            <Vertex pos="-1 0.25 2" />
                            <Vertex pos="-1 0.25 -2" />
                            <Vertex pos="-1 -0.25 2" />
                            <Vertex pos="-1 -0.25 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -832 0 0 -1 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 960 0 0 -1 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 128 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_grid_blank2" texgens="1 0 0 128 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_edge_white" texgens="1 0 0 256 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_edge_white" texgens="-1 0 0 -128 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="110" owner="0" type="0" pos="-42.25 -20.75 5.5" rot="1 0 0 0" scale="" transform="1 0 0 -42.25 0 1 0 -20.75 0 0 1 5.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 2" />
                            <Vertex pos="0.25 0.25 -2" />
                            <Vertex pos="0.25 -0.25 2" />
                            <Vertex pos="0.25 -0.25 -2" />
                            <Vertex pos="-0.25 0.25 2" />
                            <Vertex pos="-0.25 0.25 -2" />
                            <Vertex pos="-0.25 -0.25 2" />
                            <Vertex pos="-0.25 -0.25 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -832 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 960 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="111" owner="0" type="0" pos="-37.75 -20.75 5.5" rot="1 0 0 0" scale="" transform="1 0 0 -37.75 0 1 0 -20.75 0 0 1 5.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 2" />
                            <Vertex pos="0.25 0.25 -2" />
                            <Vertex pos="0.25 -0.25 2" />
                            <Vertex pos="0.25 -0.25 -2" />
                            <Vertex pos="-0.25 0.25 2" />
                            <Vertex pos="-0.25 0.25 -2" />
                            <Vertex pos="-0.25 -0.25 2" />
                            <Vertex pos="-0.25 -0.25 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -832 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 960 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="112" owner="0" type="0" pos="-34.75 19.75 6.25" rot="1 0 0 0" scale="" transform="1 0 0 -34.75 0 1 0 19.75 0 0 1 6.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 3.75 0.25" />
                            <Vertex pos="0.25 3.75 -0.25" />
                            <Vertex pos="0.25 -3.75 0.25" />
                            <Vertex pos="0.25 -3.75 -0.25" />
                            <Vertex pos="-0.25 3.75 0.25" />
                            <Vertex pos="-0.25 3.75 -0.25" />
                            <Vertex pos="-0.25 -3.75 0.25" />
                            <Vertex pos="-0.25 -3.75 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3.75" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3.75" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="113" owner="0" type="0" pos="-39.25 22.25 6.25" rot="1 0 0 0" scale="" transform="1 0 0 -39.25 0 1 0 22.25 0 0 1 6.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 6.25 0.25" />
                            <Vertex pos="0.25 6.25 -0.25" />
                            <Vertex pos="0.25 -6.25 0.25" />
                            <Vertex pos="0.25 -6.25 -0.25" />
                            <Vertex pos="-0.25 6.25 0.25" />
                            <Vertex pos="-0.25 6.25 -0.25" />
                            <Vertex pos="-0.25 -6.25 0.25" />
                            <Vertex pos="-0.25 -6.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 704 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -576 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="114" owner="0" type="0" pos="-35 28.25 6.25" rot="1 0 0 0" scale="" transform="1 0 0 -35 0 1 0 28.25 0 0 1 6.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.25 0.25" />
                            <Vertex pos="4 0.25 -0.25" />
                            <Vertex pos="4 -0.25 0.25" />
                            <Vertex pos="4 -0.25 -0.25" />
                            <Vertex pos="-4 0.25 0.25" />
                            <Vertex pos="-4 0.25 -0.25" />
                            <Vertex pos="-4 -0.25 0.25" />
                            <Vertex pos="-4 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 128 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 0 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="115" owner="0" type="0" pos="-33 23.75 6.25" rot="1 0 0 0" scale="" transform="1 0 0 -33 0 1 0 23.75 0 0 1 6.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.25 0.25" />
                            <Vertex pos="2 0.25 -0.25" />
                            <Vertex pos="2 -0.25 0.25" />
                            <Vertex pos="2 -0.25 -0.25" />
                            <Vertex pos="-2 0.25 0.25" />
                            <Vertex pos="-2 0.25 -0.25" />
                            <Vertex pos="-2 -0.25 0.25" />
                            <Vertex pos="-2 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -384 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 512 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="116" owner="0" type="0" pos="-2.75 23 2.75" rot="1 0 0 0" scale="" transform="1 0 0 -2.75 0 1 0 23 0 0 1 2.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 3 0.25" />
                            <Vertex pos="0.25 3 -0.25" />
                            <Vertex pos="0.25 -3 0.25" />
                            <Vertex pos="0.25 -3 -0.25" />
                            <Vertex pos="-0.25 3 0.25" />
                            <Vertex pos="-0.25 3 -0.25" />
                            <Vertex pos="-0.25 -3 0.25" />
                            <Vertex pos="-0.25 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="117" owner="0" type="0" pos="-6.75 27 2.75" rot="1 0 0 0" scale="" transform="1 0 0 -6.75 0 1 0 27 0 0 1 2.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1 0.25" />
                            <Vertex pos="0.25 1 -0.25" />
                            <Vertex pos="0.25 -1 0.25" />
                            <Vertex pos="0.25 -1 -0.25" />
                            <Vertex pos="-0.25 1 0.25" />
                            <Vertex pos="-0.25 1 -0.25" />
                            <Vertex pos="-0.25 -1 0.25" />
                            <Vertex pos="-0.25 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="118" owner="0" type="0" pos="-4.5 26.25 2.75" rot="1 0 0 0" scale="" transform="1 0 0 -4.5 0 1 0 26.25 0 0 1 2.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.25 0.25" />
                            <Vertex pos="2 0.25 -0.25" />
                            <Vertex pos="2 -0.25 0.25" />
                            <Vertex pos="2 -0.25 -0.25" />
                            <Vertex pos="-2 0.25 0.25" />
                            <Vertex pos="-2 0.25 -0.25" />
                            <Vertex pos="-2 -0.25 0.25" />
                            <Vertex pos="-2 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -384 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 512 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="119" owner="0" type="0" pos="-7.25 22 2.75" rot="1 0 0 0" scale="" transform="1 0 0 -7.25 0 1 0 22 0 0 1 2.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 0.25" />
                            <Vertex pos="0.25 2 -0.25" />
                            <Vertex pos="0.25 -2 0.25" />
                            <Vertex pos="0.25 -2 -0.25" />
                            <Vertex pos="-0.25 2 0.25" />
                            <Vertex pos="-0.25 2 -0.25" />
                            <Vertex pos="-0.25 -2 0.25" />
                            <Vertex pos="-0.25 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="120" owner="0" type="0" pos="-6.75 17 2.75" rot="1 0 0 0" scale="" transform="1 0 0 -6.75 0 1 0 17 0 0 1 2.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.25 3 0.25" />
                            <Vertex pos="-0.25 3 -0.25" />
                            <Vertex pos="0.75 -3 0.25" />
                            <Vertex pos="0.75 -3 -0.25" />
                            <Vertex pos="-0.75 3 0.25" />
                            <Vertex pos="-0.75 3 -0.25" />
                            <Vertex pos="0.25 -3 0.25" />
                            <Vertex pos="0.25 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.986394 0.164399 0 -0.246598" album="" material="bm_edge_white" texgens="0 1 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.986394 -0.164399 0 -0.246598" album="" material="bm_edge_white" texgens="0 -1 0 256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 192 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0.166667 0 64.006 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 -0.166667 0 64.0021 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="121" owner="0" type="0" pos="-2.25 17 2.75" rot="1 0 0 0" scale="" transform="1 0 0 -2.25 0 1 0 17 0 0 1 2.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.25 3 0.25" />
                            <Vertex pos="-0.25 3 -0.25" />
                            <Vertex pos="0.75 -3 0.25" />
                            <Vertex pos="0.75 -3 -0.25" />
                            <Vertex pos="-0.75 3 0.25" />
                            <Vertex pos="-0.75 3 -0.25" />
                            <Vertex pos="0.25 -3 0.25" />
                            <Vertex pos="0.25 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.986394 0.164399 0 -0.246598" album="" material="bm_edge_white" texgens="0 1 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.986394 -0.164399 0 -0.246598" album="" material="bm_edge_white" texgens="0 -1 0 256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 192 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0.166667 0 64.0007 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 -0.166667 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="122" owner="0" type="0" pos="-6.25 12 2.75" rot="1 0 0 0" scale="" transform="1 0 0 -6.25 0 1 0 12 0 0 1 2.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 0.25" />
                            <Vertex pos="0.25 2 -0.25" />
                            <Vertex pos="0.25 -2 0.25" />
                            <Vertex pos="0.25 -2 -0.25" />
                            <Vertex pos="-0.25 2 0.25" />
                            <Vertex pos="-0.25 2 -0.25" />
                            <Vertex pos="-0.25 -2 0.25" />
                            <Vertex pos="-0.25 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="123" owner="0" type="0" pos="-6.25 8 3.5" rot="1 0 0 0" scale="" transform="1 0 0 -6.25 0 1 0 8 0 0 1 3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 -0.5" />
                            <Vertex pos="0.25 2 -1" />
                            <Vertex pos="0.25 -2 1" />
                            <Vertex pos="0.25 -2 0.5" />
                            <Vertex pos="-0.25 2 -0.5" />
                            <Vertex pos="-0.25 2 -1" />
                            <Vertex pos="-0.25 -2 1" />
                            <Vertex pos="-0.25 -2 0.5" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 512 0 -0.375 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.351123 0.936329 -0.234082" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.351123 -0.936329 -0.234082" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="124" owner="0" type="0" pos="-6.25 2.75 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -6.25 0 1 0 2.75 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 3.25 0.25" />
                            <Vertex pos="0.25 3.25 -0.25" />
                            <Vertex pos="0.25 -3.25 0.25" />
                            <Vertex pos="0.25 -3.25 -0.25" />
                            <Vertex pos="-0.25 3.25 0.25" />
                            <Vertex pos="-0.25 3.25 -0.25" />
                            <Vertex pos="-0.25 -3.25 0.25" />
                            <Vertex pos="-0.25 -3.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -192 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 320 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="125" owner="0" type="0" pos="-3 -0.25 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -3 0 1 0 -0.25 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 0.25 0.25" />
                            <Vertex pos="3 0.25 -0.25" />
                            <Vertex pos="3 -0.25 0.25" />
                            <Vertex pos="3 -0.25 -0.25" />
                            <Vertex pos="-3 0.25 0.25" />
                            <Vertex pos="-3 0.25 -0.25" />
                            <Vertex pos="-3 -0.25 0.25" />
                            <Vertex pos="-3 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -128 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 256 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="126" owner="0" type="0" pos="10.25 -0.25 5.75" rot="1 0 0 0" scale="" transform="1 0 0 10.25 0 1 0 -0.25 0 0 1 5.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.25 0.25 0.25" />
                            <Vertex pos="2.25 0.25 -0.25" />
                            <Vertex pos="2.25 -0.25 0.25" />
                            <Vertex pos="2.25 -0.25 -0.25" />
                            <Vertex pos="-2.25 0.25 0.25" />
                            <Vertex pos="-2.25 0.25 -0.25" />
                            <Vertex pos="-2.25 -0.25 0.25" />
                            <Vertex pos="-2.25 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2.25" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2.25" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 448 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -320 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -320 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 448 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="127" owner="0" type="0" pos="12.25 3 5.75" rot="1 0 0 0" scale="" transform="1 0 0 12.25 0 1 0 3 0 0 1 5.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 3 0.25" />
                            <Vertex pos="0.25 3 -0.25" />
                            <Vertex pos="0.25 -3 0.25" />
                            <Vertex pos="0.25 -3 -0.25" />
                            <Vertex pos="-0.25 3 0.25" />
                            <Vertex pos="-0.25 3 -0.25" />
                            <Vertex pos="-0.25 -3 0.25" />
                            <Vertex pos="-0.25 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="128" owner="23" type="999" pos="12.25 8.25 5.75" rot="1 0 0 0" scale="" transform="1 0 0 12.25 0 1 0 8.25 0 0 1 5.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2.25 0.25" />
                            <Vertex pos="0.25 2.25 -0.25" />
                            <Vertex pos="0.25 -2.25 0.25" />
                            <Vertex pos="0.25 -2.25 -0.25" />
                            <Vertex pos="-0.25 1.75 0.25" />
                            <Vertex pos="-0.25 1.75 -0.25" />
                            <Vertex pos="-0.25 -2.25 0.25" />
                            <Vertex pos="-0.25 -2.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_mp1" texgens="0 1 0 -448 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_mp1" texgens="0 -1 0 576 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -1.41421" album="" material="bm_edge_mp1" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2.25" album="" material="bm_edge_mp1" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_mp1" texgens="0 -1 0 -448 -1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_mp1" texgens="0 -1 0 -448 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="129" owner="23" type="999" pos="11.25 10.25 5.75" rot="1 0 0 0" scale="" transform="1 0 0 11.25 0 1 0 10.25 0 0 1 5.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.25 0.25 0.25" />
                            <Vertex pos="1.25 0.25 -0.25" />
                            <Vertex pos="0.749999 -0.25 0.25" />
                            <Vertex pos="0.749999 -0.25 -0.25" />
                            <Vertex pos="-1.25 0.25 0.25" />
                            <Vertex pos="-1.25 0.25 -0.25" />
                            <Vertex pos="-1.25 -0.25 0.25" />
                            <Vertex pos="-1.25 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.707106 -0.707107 0 -0.707106" album="" material="bm_edge_mp1" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1.25" album="" material="bm_edge_mp1" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_mp1" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_mp1" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_mp1" texgens="1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_mp1" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="130" owner="0" type="0" pos="-6 5.75 9.75" rot="1 0 0 0" scale="" transform="1 0 0 -6 0 1 0 5.75 0 0 1 9.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.25 0.25" />
                            <Vertex pos="4 0.25 -0.25" />
                            <Vertex pos="4 -0.25 0.25" />
                            <Vertex pos="4 -0.25 -0.25" />
                            <Vertex pos="-4 0.25 0.25" />
                            <Vertex pos="-4 0.25 -0.25" />
                            <Vertex pos="-4 -0.25 0.25" />
                            <Vertex pos="-4 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -384 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 512 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="131" owner="0" type="0" pos="-6 10.25 9.75" rot="1 0 0 0" scale="" transform="1 0 0 -6 0 1 0 10.25 0 0 1 9.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.25 0.25" />
                            <Vertex pos="4 0.25 -0.25" />
                            <Vertex pos="4 -0.25 0.25" />
                            <Vertex pos="4 -0.25 -0.25" />
                            <Vertex pos="-4 0.25 0.25" />
                            <Vertex pos="-4 0.25 -0.25" />
                            <Vertex pos="-4 -0.25 0.25" />
                            <Vertex pos="-4 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -384 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 512 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="132" owner="0" type="0" pos="-26.25 -28 0.25" rot="1 0 0 0" scale="" transform="1 0 0 -26.25 0 1 0 -28 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 9 0.25" />
                            <Vertex pos="0.25 9 -0.25" />
                            <Vertex pos="0.25 -9 0.25" />
                            <Vertex pos="0.25 -9 -0.25" />
                            <Vertex pos="-0.25 9 0.25" />
                            <Vertex pos="-0.25 9 -0.25" />
                            <Vertex pos="-0.25 -9 0.25" />
                            <Vertex pos="-0.25 -9 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 1792 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -9" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -9" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="133" owner="0" type="0" pos="-21.75 -28 0.25" rot="1 0 0 0" scale="" transform="1 0 0 -21.75 0 1 0 -28 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 9 0.25" />
                            <Vertex pos="0.25 9 -0.25" />
                            <Vertex pos="0.25 -9 0.25" />
                            <Vertex pos="0.25 -9 -0.25" />
                            <Vertex pos="-0.25 9 0.25" />
                            <Vertex pos="-0.25 9 -0.25" />
                            <Vertex pos="-0.25 -9 0.25" />
                            <Vertex pos="-0.25 -9 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 1792 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -9" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -9" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="134" owner="0" type="0" pos="-26.25 -30.75 8.25" rot="1 0 0 0" scale="" transform="1 0 0 -26.25 0 1 0 -30.75 0 0 1 8.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 6.25 0.25" />
                            <Vertex pos="0.25 6.25 -0.25" />
                            <Vertex pos="0.25 -6.25 0.25" />
                            <Vertex pos="0.25 -6.25 -0.25" />
                            <Vertex pos="-0.25 6.25 0.25" />
                            <Vertex pos="-0.25 6.25 -0.25" />
                            <Vertex pos="-0.25 -6.25 0.25" />
                            <Vertex pos="-0.25 -6.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -2368 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 2496 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 2496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 2496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="135" owner="0" type="0" pos="-21.75 -33.25 8.25" rot="1 0 0 0" scale="" transform="1 0 0 -21.75 0 1 0 -33.25 0 0 1 8.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 3.75 0.25" />
                            <Vertex pos="0.25 3.75 -0.25" />
                            <Vertex pos="0.25 -3.75 0.25" />
                            <Vertex pos="0.25 -3.75 -0.25" />
                            <Vertex pos="-0.25 3.75 0.25" />
                            <Vertex pos="-0.25 3.75 -0.25" />
                            <Vertex pos="-0.25 -3.75 0.25" />
                            <Vertex pos="-0.25 -3.75 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -3008 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 3136 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3.75" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3.75" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 3136 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 3136 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="136" owner="0" type="0" pos="-20 -24.75 8.25" rot="1 0 0 0" scale="" transform="1 0 0 -20 0 1 0 -24.75 0 0 1 8.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 0.25 0.25" />
                            <Vertex pos="6 0.25 -0.25" />
                            <Vertex pos="6 -0.25 0.25" />
                            <Vertex pos="6 -0.25 -0.25" />
                            <Vertex pos="-6 0.25 0.25" />
                            <Vertex pos="-6 0.25 -0.25" />
                            <Vertex pos="-6 -0.25 0.25" />
                            <Vertex pos="-6 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -384 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 512 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="137" owner="0" type="0" pos="-18 -29.25 8.25" rot="1 0 0 0" scale="" transform="1 0 0 -18 0 1 0 -29.25 0 0 1 8.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.25 0.25" />
                            <Vertex pos="4 0.25 -0.25" />
                            <Vertex pos="4 -0.25 0.25" />
                            <Vertex pos="4 -0.25 -0.25" />
                            <Vertex pos="-4 0.25 0.25" />
                            <Vertex pos="-4 0.25 -0.25" />
                            <Vertex pos="-4 -0.25 0.25" />
                            <Vertex pos="-4 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1024 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -896 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1024 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="138" owner="0" type="0" pos="-26.25 -31 10.75" rot="1 0 0 0" scale="" transform="1 0 0 -26.25 0 1 0 -31 0 0 1 10.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 6 0.25" />
                            <Vertex pos="0.25 6 -0.25" />
                            <Vertex pos="0.25 -6 0.25" />
                            <Vertex pos="0.25 -6 -0.25" />
                            <Vertex pos="-0.25 6 0.25" />
                            <Vertex pos="-0.25 6 -0.25" />
                            <Vertex pos="-0.25 -6 0.25" />
                            <Vertex pos="-0.25 -6 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -2432 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 2560 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="139" owner="0" type="0" pos="-21.75 -31 10.75" rot="1 0 0 0" scale="" transform="1 0 0 -21.75 0 1 0 -31 0 0 1 10.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 6 0.25" />
                            <Vertex pos="0.25 6 -0.25" />
                            <Vertex pos="0.25 -6 0.25" />
                            <Vertex pos="0.25 -6 -0.25" />
                            <Vertex pos="-0.25 6 0.25" />
                            <Vertex pos="-0.25 6 -0.25" />
                            <Vertex pos="-0.25 -6 0.25" />
                            <Vertex pos="-0.25 -6 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -2432 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 2560 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="140" owner="0" type="0" pos="-24 -24.75 10.75" rot="1 0 0 0" scale="" transform="1 0 0 -24 0 1 0 -24.75 0 0 1 10.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.5 0.25 0.25" />
                            <Vertex pos="2.5 0.25 -0.25" />
                            <Vertex pos="2.5 -0.25 0.25" />
                            <Vertex pos="2.5 -0.25 -0.25" />
                            <Vertex pos="-2.5 0.25 0.25" />
                            <Vertex pos="-2.5 0.25 -0.25" />
                            <Vertex pos="-2.5 -0.25 0.25" />
                            <Vertex pos="-2.5 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2.5" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2.5" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1280 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1280 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1408 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="141" owner="0" type="0" pos="-26.25 -24.75 9.5" rot="1 0 0 0" scale="" transform="1 0 0 -26.25 0 1 0 -24.75 0 0 1 9.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 1" />
                            <Vertex pos="0.25 0.25 -1" />
                            <Vertex pos="0.25 -0.25 1" />
                            <Vertex pos="0.25 -0.25 -1" />
                            <Vertex pos="-0.25 0.25 1" />
                            <Vertex pos="-0.25 0.25 -1" />
                            <Vertex pos="-0.25 -0.25 1" />
                            <Vertex pos="-0.25 -0.25 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1856 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_edge_white" texgens="1 0 0 -1856 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="142" owner="0" type="0" pos="-21.75 -24.75 9.5" rot="1 0 0 0" scale="" transform="1 0 0 -21.75 0 1 0 -24.75 0 0 1 9.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 1" />
                            <Vertex pos="0.25 0.25 -1" />
                            <Vertex pos="0.25 -0.25 1" />
                            <Vertex pos="0.25 -0.25 -1" />
                            <Vertex pos="-0.25 0.25 1" />
                            <Vertex pos="-0.25 0.25 -1" />
                            <Vertex pos="-0.25 -0.25 1" />
                            <Vertex pos="-0.25 -0.25 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1856 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_edge_white" texgens="1 0 0 -1856 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_edge_white" texgens="-1 0 0 1984 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="143" owner="0" type="0" pos="-24 -24.75 9.5" rot="1 0 0 0" scale="" transform="1 0 0 -24 0 1 0 -24.75 0 0 1 9.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.25 1" />
                            <Vertex pos="2 0.25 -1" />
                            <Vertex pos="2 -0.25 1" />
                            <Vertex pos="2 -0.25 -1" />
                            <Vertex pos="-2 0.25 1" />
                            <Vertex pos="-2 0.25 -1" />
                            <Vertex pos="-2 -0.25 1" />
                            <Vertex pos="-2 -0.25 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -832 0 0 -1 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 960 0 0 -1 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_grid_blank2" texgens="1 0 0 256 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_edge_white" texgens="1 0 0 512 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="144" owner="0" type="0" pos="2.25 -28 11.75" rot="1 0 0 0" scale="" transform="1 0 0 2.25 0 1 0 -28 0 0 1 11.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1 0.25" />
                            <Vertex pos="0.25 1 -0.25" />
                            <Vertex pos="0.25 -1 0.25" />
                            <Vertex pos="0.25 -1 -0.25" />
                            <Vertex pos="-0.25 1 0.25" />
                            <Vertex pos="-0.25 1 -0.25" />
                            <Vertex pos="-0.25 -1 0.25" />
                            <Vertex pos="-0.25 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="145" owner="0" type="0" pos="1.75 -22 11.75" rot="1 0 0 0" scale="" transform="1 0 0 1.75 0 1 0 -22 0 0 1 11.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 3 0.25" />
                            <Vertex pos="0.25 3 -0.25" />
                            <Vertex pos="0.25 -3 0.25" />
                            <Vertex pos="0.25 -3 -0.25" />
                            <Vertex pos="-0.25 3 0.25" />
                            <Vertex pos="-0.25 3 -0.25" />
                            <Vertex pos="-0.25 -3 0.25" />
                            <Vertex pos="-0.25 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="146" owner="0" type="0" pos="6.25 -23 11.75" rot="1 0 0 0" scale="" transform="1 0 0 6.25 0 1 0 -23 0 0 1 11.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4 0.25" />
                            <Vertex pos="0.25 4 -0.25" />
                            <Vertex pos="0.25 -4 0.25" />
                            <Vertex pos="0.25 -4 -0.25" />
                            <Vertex pos="-0.25 4 0.25" />
                            <Vertex pos="-0.25 4 -0.25" />
                            <Vertex pos="-0.25 -4 0.25" />
                            <Vertex pos="-0.25 -4 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="147" owner="0" type="0" pos="4.5 -27.25 11.75" rot="1 0 0 0" scale="" transform="1 0 0 4.5 0 1 0 -27.25 0 0 1 11.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.25 0.25" />
                            <Vertex pos="2 0.25 -0.25" />
                            <Vertex pos="2 -0.25 0.25" />
                            <Vertex pos="2 -0.25 -0.25" />
                            <Vertex pos="-2 0.25 0.25" />
                            <Vertex pos="-2 0.25 -0.25" />
                            <Vertex pos="-2 -0.25 0.25" />
                            <Vertex pos="-2 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -384 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 512 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="148" owner="0" type="0" pos="-26 31.75 9.25" rot="1 0 0 0" scale="" transform="1 0 0 -26 0 1 0 31.75 0 0 1 9.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 0.25 0.25" />
                            <Vertex pos="3 0.25 -0.25" />
                            <Vertex pos="3 -0.25 0.25" />
                            <Vertex pos="3 -0.25 -0.25" />
                            <Vertex pos="-3 0.25 0.25" />
                            <Vertex pos="-3 0.25 -0.25" />
                            <Vertex pos="-3 -0.25 0.25" />
                            <Vertex pos="-3 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -640 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 768 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="149" owner="0" type="0" pos="-26 36.25 9.25" rot="1 0 0 0" scale="" transform="1 0 0 -26 0 1 0 36.25 0 0 1 9.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 0.25 0.25" />
                            <Vertex pos="3 0.25 -0.25" />
                            <Vertex pos="3 -0.25 0.25" />
                            <Vertex pos="3 -0.25 -0.25" />
                            <Vertex pos="-3 0.25 0.25" />
                            <Vertex pos="-3 0.25 -0.25" />
                            <Vertex pos="-3 -0.25 0.25" />
                            <Vertex pos="-3 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -640 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 768 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="150" owner="0" type="0" pos="-36 33.75 9.25" rot="1 0 0 0" scale="" transform="1 0 0 -36 0 1 0 33.75 0 0 1 9.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 0.25 0.25" />
                            <Vertex pos="3 0.25 -0.25" />
                            <Vertex pos="3 -0.25 0.25" />
                            <Vertex pos="3 -0.25 -0.25" />
                            <Vertex pos="-3 0.25 0.25" />
                            <Vertex pos="-3 0.25 -0.25" />
                            <Vertex pos="-3 -0.25 0.25" />
                            <Vertex pos="-3 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -640 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 768 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="151" owner="0" type="0" pos="-36 38.25 9.25" rot="1 0 0 0" scale="" transform="1 0 0 -36 0 1 0 38.25 0 0 1 9.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 0.25 0.25" />
                            <Vertex pos="3 0.25 -0.25" />
                            <Vertex pos="3 -0.25 0.25" />
                            <Vertex pos="3 -0.25 -0.25" />
                            <Vertex pos="-3 0.25 0.25" />
                            <Vertex pos="-3 0.25 -0.25" />
                            <Vertex pos="-3 -0.25 0.25" />
                            <Vertex pos="-3 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -640 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 768 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="152" owner="0" type="0" pos="-31 32.75 9.25" rot="1 0 0 0" scale="" transform="1 0 0 -31 0 1 0 32.75 0 0 1 9.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -0.750002 0.249999" />
                            <Vertex pos="2 -0.750002 -0.25" />
                            <Vertex pos="2 -1.25 0.249999" />
                            <Vertex pos="2 -1.25 -0.25" />
                            <Vertex pos="-2 1.25 0.249999" />
                            <Vertex pos="-2 1.25 -0.25" />
                            <Vertex pos="-2 0.75 0.249999" />
                            <Vertex pos="-2 0.75 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 320 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 -192 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.447214 0.894427 -0 -0.223606" album="" material="bm_edge_white" texgens="-1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.447214 -0.894427 -0 -0.223607" album="" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 0 1 -0.249999" album="" material="bm_edge_white" texgens="1 0 0 512 -0.5 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 512 -0.5 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="153" owner="0" type="0" pos="-31 37.25 9.25" rot="1 0 0 0" scale="" transform="1 0 0 -31 0 1 0 37.25 0 0 1 9.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -0.750004 0.249999" />
                            <Vertex pos="2 -0.750004 -0.25" />
                            <Vertex pos="2 -1.25 0.249999" />
                            <Vertex pos="2 -1.25 -0.25" />
                            <Vertex pos="-2 1.25 0.249999" />
                            <Vertex pos="-2 1.25 -0.25" />
                            <Vertex pos="-2 0.75 0.249999" />
                            <Vertex pos="-2 0.75 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 320 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 -192 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.447214 0.894427 -0 -0.223605" album="" material="bm_edge_white" texgens="-1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.447214 -0.894427 -0 -0.223607" album="" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 0 1 -0.249999" album="" material="bm_edge_white" texgens="1 0 0 512 -0.5 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 512 -0.5 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="154" owner="0" type="0" pos="-15.25 55.75 -1.25" rot="1 0 0 0" scale="" transform="1 0 0 -15.25 0 1 0 55.75 0 0 1 -1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3.75 0.25 0.25" />
                            <Vertex pos="3.75 0.25 -0.25" />
                            <Vertex pos="3.75 -0.25 0.25" />
                            <Vertex pos="3.75 -0.25 -0.25" />
                            <Vertex pos="-3.75 0.25 0.25" />
                            <Vertex pos="-3.75 0.25 -0.25" />
                            <Vertex pos="-3.75 -0.25 0.25" />
                            <Vertex pos="-3.75 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3.75" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3.75" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 576 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -448 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -448 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 576 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="155" owner="0" type="0" pos="-12.75 60.25 -1.25" rot="1 0 0 0" scale="" transform="1 0 0 -12.75 0 1 0 60.25 0 0 1 -1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6.25 0.25 0.25" />
                            <Vertex pos="6.25 0.25 -0.25" />
                            <Vertex pos="6.25 -0.25 0.25" />
                            <Vertex pos="6.25 -0.25 -0.25" />
                            <Vertex pos="-6.25 0.25 0.25" />
                            <Vertex pos="-6.25 0.25 -0.25" />
                            <Vertex pos="-6.25 -0.25 0.25" />
                            <Vertex pos="-6.25 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6.25" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6.25" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 192 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 192 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="156" owner="0" type="0" pos="-6.75 56 -1.25" rot="1 0 0 0" scale="" transform="1 0 0 -6.75 0 1 0 56 0 0 1 -1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4 0.25" />
                            <Vertex pos="0.25 4 -0.25" />
                            <Vertex pos="0.25 -4 0.25" />
                            <Vertex pos="0.25 -4 -0.25" />
                            <Vertex pos="-0.25 4 0.25" />
                            <Vertex pos="-0.25 4 -0.25" />
                            <Vertex pos="-0.25 -4 0.25" />
                            <Vertex pos="-0.25 -4 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="157" owner="0" type="0" pos="-11.25 54 -1.25" rot="1 0 0 0" scale="" transform="1 0 0 -11.25 0 1 0 54 0 0 1 -1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 0.25" />
                            <Vertex pos="0.25 2 -0.25" />
                            <Vertex pos="0.25 -2 0.25" />
                            <Vertex pos="0.25 -2 -0.25" />
                            <Vertex pos="-0.25 2 0.25" />
                            <Vertex pos="-0.25 2 -0.25" />
                            <Vertex pos="-0.25 -2 0.25" />
                            <Vertex pos="-0.25 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="158" owner="0" type="0" pos="-14.75 1 2.75" rot="1 0 0 0" scale="" transform="1 0 0 -14.75 0 1 0 1 0 0 1 2.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4 0.25" />
                            <Vertex pos="0.25 4 -0.25" />
                            <Vertex pos="0.25 -4 0.25" />
                            <Vertex pos="0.25 -4 -0.25" />
                            <Vertex pos="-0.25 4 0.25" />
                            <Vertex pos="-0.25 4 -0.25" />
                            <Vertex pos="-0.25 -4 0.25" />
                            <Vertex pos="-0.25 -4 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="159" owner="0" type="0" pos="-19.25 1 2.75" rot="1 0 0 0" scale="" transform="1 0 0 -19.25 0 1 0 1 0 0 1 2.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4 0.25" />
                            <Vertex pos="0.25 4 -0.25" />
                            <Vertex pos="0.25 -4 0.25" />
                            <Vertex pos="0.25 -4 -0.25" />
                            <Vertex pos="-0.25 4 0.25" />
                            <Vertex pos="-0.25 4 -0.25" />
                            <Vertex pos="-0.25 -4 0.25" />
                            <Vertex pos="-0.25 -4 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="160" owner="0" type="0" pos="-17 -3.25 2.75" rot="1 0 0 0" scale="" transform="1 0 0 -17 0 1 0 -3.25 0 0 1 2.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.5 0.25 0.25" />
                            <Vertex pos="2.5 0.25 -0.25" />
                            <Vertex pos="2.5 -0.25 0.25" />
                            <Vertex pos="2.5 -0.25 -0.25" />
                            <Vertex pos="-2.5 0.25 0.25" />
                            <Vertex pos="-2.5 0.25 -0.25" />
                            <Vertex pos="-2.5 -0.25 0.25" />
                            <Vertex pos="-2.5 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2.5" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2.5" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="161" owner="0" type="0" pos="-22.875 34 9.25" rot="1 0 0 0" scale="" transform="1 0 0 -22.875 0 1 0 34 0 0 1 9.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 2.5 0.25" />
                            <Vertex pos="0.125 2.5 -0.25" />
                            <Vertex pos="0.125 -2.5 0.25" />
                            <Vertex pos="0.125 -2.5 -0.25" />
                            <Vertex pos="-0.125 2.5 0.25" />
                            <Vertex pos="-0.125 2.5 -0.25" />
                            <Vertex pos="-0.125 -2.5 0.25" />
                            <Vertex pos="-0.125 -2.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_trim" texgens="0 1 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_trim" texgens="0 -1 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2.5" album="" material="bm_trim" texgens="-1 0 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2.5" album="" material="bm_trim" texgens="1 0 0 32 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_trim" texgens="1 0 0 32 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_trim" texgens="-1 0 0 96 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="162" owner="0" type="0" pos="4 -18.875 11.75" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 -18.875 0 0 1 11.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.5 0.125 0.25" />
                            <Vertex pos="2.5 0.125 -0.25" />
                            <Vertex pos="2.5 -0.125 0.25" />
                            <Vertex pos="2.5 -0.125 -0.25" />
                            <Vertex pos="-2.5 0.125 0.25" />
                            <Vertex pos="-2.5 0.125 -0.25" />
                            <Vertex pos="-2.5 -0.125 0.25" />
                            <Vertex pos="-2.5 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2.5" album="" material="bm_trim" texgens="0 1 0 32 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2.5" album="" material="bm_trim" texgens="0 -1 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_trim" texgens="-1 0 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_trim" texgens="1 0 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_trim" texgens="1 0 0 640 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_trim" texgens="-1 0 0 -512 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="163" owner="0" type="0" pos="0.125 0.75 4.25" rot="1 0 0 0" scale="" transform="1 0 0 0.125 0 1 0 0.75 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 1.25 0.25" />
                            <Vertex pos="0.125 1.25 -0.25" />
                            <Vertex pos="0.125 -1.25 0.25" />
                            <Vertex pos="0.125 -1.25 -0.25" />
                            <Vertex pos="-0.125 1.25 0.25" />
                            <Vertex pos="-0.125 1.25 -0.25" />
                            <Vertex pos="-0.125 -1.25 0.25" />
                            <Vertex pos="-0.125 -1.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_trim" texgens="0 1 0 960 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_trim" texgens="0 -1 0 -832 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1.25" album="" material="bm_trim" texgens="-1 0 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.25" album="" material="bm_trim" texgens="1 0 0 32 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_trim" texgens="1 0 0 32 0 -1 0 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_trim" texgens="-1 0 0 96 0 -1 0 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="164" owner="0" type="0" pos="7.875 0.75 5.75" rot="1 0 0 0" scale="" transform="1 0 0 7.875 0 1 0 0.75 0 0 1 5.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 1.25 0.25" />
                            <Vertex pos="0.125 1.25 -0.25" />
                            <Vertex pos="0.125 -1.25 0.25" />
                            <Vertex pos="0.125 -1.25 -0.25" />
                            <Vertex pos="-0.125 1.25 0.25" />
                            <Vertex pos="-0.125 1.25 -0.25" />
                            <Vertex pos="-0.125 -1.25 0.25" />
                            <Vertex pos="-0.125 -1.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_trim" texgens="0 1 0 960 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_trim" texgens="0 -1 0 -832 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1.25" album="" material="bm_trim" texgens="-1 0 0 32 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.25" album="" material="bm_trim" texgens="1 0 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_trim" texgens="1 0 0 96 0 -1 0 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_trim" texgens="-1 0 0 32 0 -1 0 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="165" owner="0" type="0" pos="1.75 1.75 18.25" rot="1 0 0 0" scale="" transform="1 0 0 1.75 0 1 0 1.75 0 0 1 18.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 1.75" />
                            <Vertex pos="0.25 0.25 -1.25" />
                            <Vertex pos="0.25 -0.25 1.75" />
                            <Vertex pos="0.25 -0.25 -1.25" />
                            <Vertex pos="-0.25 0.25 1.75" />
                            <Vertex pos="-0.25 0.25 -1.75" />
                            <Vertex pos="-0.25 -0.25 1.75" />
                            <Vertex pos="-0.25 -0.25 -1.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1.75" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.707107 0 -0.707107 -1.06066" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="166" owner="0" type="0" pos="6.25 1.75 18.25" rot="1 0 0 0" scale="" transform="1 0 0 6.25 0 1 0 1.75 0 0 1 18.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 1.75" />
                            <Vertex pos="0.25 0.25 -1.75" />
                            <Vertex pos="0.25 -0.25 1.75" />
                            <Vertex pos="0.25 -0.25 -1.75" />
                            <Vertex pos="-0.25 0.25 1.75" />
                            <Vertex pos="-0.25 0.25 -1.25" />
                            <Vertex pos="-0.25 -0.25 1.75" />
                            <Vertex pos="-0.25 -0.25 -1.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1.75" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.707107 0 -0.707107 -1.06066" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="167" owner="0" type="0" pos="10.25 10.25 11" rot="1 0 0 0" scale="" transform="1 0 0 10.25 0 1 0 10.25 0 0 1 11 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 1" />
                            <Vertex pos="0.25 0.25 -1" />
                            <Vertex pos="0.25 -0.25 1" />
                            <Vertex pos="0.25 -0.25 -1" />
                            <Vertex pos="-0.25 0.25 1" />
                            <Vertex pos="-0.25 0.25 -1" />
                            <Vertex pos="-0.25 -0.25 1" />
                            <Vertex pos="-0.25 -0.25 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 448 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -320 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="168" owner="0" type="0" pos="10.25 5.75 10.5" rot="1 0 0 0" scale="" transform="1 0 0 10.25 0 1 0 5.75 0 0 1 10.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 1.5" />
                            <Vertex pos="0.25 0.25 -1" />
                            <Vertex pos="0.25 -0.25 1.5" />
                            <Vertex pos="0.25 -0.25 -1" />
                            <Vertex pos="-0.25 0.25 1.5" />
                            <Vertex pos="-0.25 0.25 -1.5" />
                            <Vertex pos="-0.25 -0.25 1.5" />
                            <Vertex pos="-0.25 -0.25 -1.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 448 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -320 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1.5" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.707107 0 -0.707107 -0.883883" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="169" owner="0" type="0" pos="-2.25 10.25 11" rot="1 0 0 0" scale="" transform="1 0 0 -2.25 0 1 0 10.25 0 0 1 11 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 1" />
                            <Vertex pos="0.25 0.25 -1" />
                            <Vertex pos="0.25 -0.25 1" />
                            <Vertex pos="0.25 -0.25 -1" />
                            <Vertex pos="-0.25 0.25 1" />
                            <Vertex pos="-0.25 0.25 -1" />
                            <Vertex pos="-0.25 -0.25 1" />
                            <Vertex pos="-0.25 -0.25 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 448 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -320 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="170" owner="0" type="0" pos="-2.25 5.75 11" rot="1 0 0 0" scale="" transform="1 0 0 -2.25 0 1 0 5.75 0 0 1 11 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 1" />
                            <Vertex pos="0.25 0.25 -1" />
                            <Vertex pos="0.25 -0.25 1" />
                            <Vertex pos="0.25 -0.25 -1" />
                            <Vertex pos="-0.25 0.25 1" />
                            <Vertex pos="-0.25 0.25 -1" />
                            <Vertex pos="-0.25 -0.25 1" />
                            <Vertex pos="-0.25 -0.25 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 448 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -320 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="171" owner="0" type="0" pos="10.25 10.25 19.5" rot="1 0 0 0" scale="" transform="1 0 0 10.25 0 1 0 10.25 0 0 1 19.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 0.5" />
                            <Vertex pos="0.25 0.25 -1.90735e-006" />
                            <Vertex pos="0.25 -0.25 0.5" />
                            <Vertex pos="0.25 -0.25 -1.90735e-006" />
                            <Vertex pos="-0.25 0.25 0.5" />
                            <Vertex pos="-0.25 0.25 -0.500002" />
                            <Vertex pos="-0.25 -0.25 0.5" />
                            <Vertex pos="-0.25 -0.25 -0.500002" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 448 0 0 -1 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -320 0 0 -1 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.707107 0 -0.707107 -0.176778" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="172" owner="0" type="0" pos="10.25 5.75 19.5" rot="1 0 0 0" scale="" transform="1 0 0 10.25 0 1 0 5.75 0 0 1 19.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 0.5" />
                            <Vertex pos="0.25 0.25 -1.90735e-006" />
                            <Vertex pos="0.25 -0.25 0.5" />
                            <Vertex pos="0.25 -0.25 -1.90735e-006" />
                            <Vertex pos="-0.25 0.25 0.5" />
                            <Vertex pos="-0.25 0.25 -0.500002" />
                            <Vertex pos="-0.25 -0.25 0.5" />
                            <Vertex pos="-0.25 -0.25 -0.500002" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 448 0 0 -1 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -320 0 0 -1 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.707107 0 -0.707107 -0.176778" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="173" owner="0" type="0" pos="9 12 16" rot="1 0 0 0" scale="" transform="1 0 0 9 0 1 0 12 0 0 1 16 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 2" />
                            <Vertex pos="1 2 -2" />
                            <Vertex pos="1 -2 2" />
                            <Vertex pos="1 -2 -2" />
                            <Vertex pos="-1 2 2" />
                            <Vertex pos="-1 2 -2" />
                            <Vertex pos="-1 -2 2" />
                            <Vertex pos="-1 -2 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank1" texgens="0 1 0 256 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank1" texgens="0 -1 0 0 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 384 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 -128 0 0 -1 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_tile09_C" texgens="1 0 0 256 0 -1 0 2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 384 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="174" owner="0" type="0" pos="9 8 15.75" rot="1 0 0 0" scale="" transform="1 0 0 9 0 1 0 8 0 0 1 15.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 1.75" />
                            <Vertex pos="1 2 -1.75" />
                            <Vertex pos="1 -2 1.75" />
                            <Vertex pos="1 -2 -1.75" />
                            <Vertex pos="-1 2 1.75" />
                            <Vertex pos="-1 2 -1.75" />
                            <Vertex pos="-1 -2 1.75" />
                            <Vertex pos="-1 -2 -1.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank1" texgens="0 1 0 256 0 0 -1 2080 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank1" texgens="0 -1 0 0 0 0 -1 2080 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 384 0 0 -1 2080 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 -128 0 0 -1 2080 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1.75" album="" material="bm_tile09_C" texgens="1 0 0 256 0 -1 0 2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1.75" album="" material="bm_grid_blank1" texgens="-1 0 0 384 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="175" owner="0" type="0" pos="9 8 17.75" rot="1 0 0 0" scale="" transform="1 0 0 9 0 1 0 8 0 0 1 17.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 0.25" />
                            <Vertex pos="1 2 -0.25" />
                            <Vertex pos="1 -2 0.25" />
                            <Vertex pos="1 -2 -0.25" />
                            <Vertex pos="-1 2 0.25" />
                            <Vertex pos="-1 2 -0.25" />
                            <Vertex pos="-1 -2 0.25" />
                            <Vertex pos="-1 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_trim" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 256 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 128 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="176" owner="0" type="0" pos="-0.25 10.25 31" rot="1 0 0 0" scale="" transform="1 0 0 -0.25 0 1 0 10.25 0 0 1 31 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 1" />
                            <Vertex pos="0.25 0.25 -1" />
                            <Vertex pos="0.25 -0.25 1" />
                            <Vertex pos="0.25 -0.25 -1" />
                            <Vertex pos="-0.25 0.25 1" />
                            <Vertex pos="-0.25 0.25 -1" />
                            <Vertex pos="-0.25 -0.25 1" />
                            <Vertex pos="-0.25 -0.25 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 448 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -320 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="177" owner="0" type="0" pos="-0.25 5.75 31" rot="1 0 0 0" scale="" transform="1 0 0 -0.25 0 1 0 5.75 0 0 1 31 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 1" />
                            <Vertex pos="0.25 0.25 -1" />
                            <Vertex pos="0.25 -0.25 1" />
                            <Vertex pos="0.25 -0.25 -1" />
                            <Vertex pos="-0.25 0.25 1" />
                            <Vertex pos="-0.25 0.25 -1" />
                            <Vertex pos="-0.25 -0.25 1" />
                            <Vertex pos="-0.25 -0.25 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 448 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -320 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="178" owner="0" type="0" pos="8.25 10.25 31" rot="1 0 0 0" scale="" transform="1 0 0 8.25 0 1 0 10.25 0 0 1 31 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 1" />
                            <Vertex pos="0.25 0.25 -1" />
                            <Vertex pos="0.25 -0.25 1" />
                            <Vertex pos="0.25 -0.25 -1" />
                            <Vertex pos="-0.25 0.25 1" />
                            <Vertex pos="-0.25 0.25 -1" />
                            <Vertex pos="-0.25 -0.25 1" />
                            <Vertex pos="-0.25 -0.25 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 448 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -320 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="179" owner="0" type="0" pos="8.25 5.75 31" rot="1 0 0 0" scale="" transform="1 0 0 8.25 0 1 0 5.75 0 0 1 31 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 1" />
                            <Vertex pos="0.25 0.25 -1" />
                            <Vertex pos="0.25 -0.25 1" />
                            <Vertex pos="0.25 -0.25 -1" />
                            <Vertex pos="-0.25 0.25 1" />
                            <Vertex pos="-0.25 0.25 -1" />
                            <Vertex pos="-0.25 -0.25 1" />
                            <Vertex pos="-0.25 -0.25 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 448 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -320 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="180" owner="0" type="0" pos="6.25 3.75 31" rot="1 0 0 0" scale="" transform="1 0 0 6.25 0 1 0 3.75 0 0 1 31 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 1" />
                            <Vertex pos="0.25 0.25 -1" />
                            <Vertex pos="0.25 -0.25 1" />
                            <Vertex pos="0.25 -0.25 -1" />
                            <Vertex pos="-0.25 0.25 1" />
                            <Vertex pos="-0.25 0.25 -1" />
                            <Vertex pos="-0.25 -0.25 1" />
                            <Vertex pos="-0.25 -0.25 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 448 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -320 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="181" owner="0" type="0" pos="1.75 3.75 31" rot="1 0 0 0" scale="" transform="1 0 0 1.75 0 1 0 3.75 0 0 1 31 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 1" />
                            <Vertex pos="0.25 0.25 -1" />
                            <Vertex pos="0.25 -0.25 1" />
                            <Vertex pos="0.25 -0.25 -1" />
                            <Vertex pos="-0.25 0.25 1" />
                            <Vertex pos="-0.25 0.25 -1" />
                            <Vertex pos="-0.25 -0.25 1" />
                            <Vertex pos="-0.25 -0.25 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 448 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -320 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="182" owner="0" type="0" pos="6.25 12.25 31" rot="1 0 0 0" scale="" transform="1 0 0 6.25 0 1 0 12.25 0 0 1 31 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 1" />
                            <Vertex pos="0.25 0.25 -1" />
                            <Vertex pos="0.25 -0.25 1" />
                            <Vertex pos="0.25 -0.25 -1" />
                            <Vertex pos="-0.25 0.25 1" />
                            <Vertex pos="-0.25 0.25 -1" />
                            <Vertex pos="-0.25 -0.25 1" />
                            <Vertex pos="-0.25 -0.25 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 448 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -320 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="183" owner="0" type="0" pos="1.75 12.25 31" rot="1 0 0 0" scale="" transform="1 0 0 1.75 0 1 0 12.25 0 0 1 31 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 1" />
                            <Vertex pos="0.25 0.25 -1" />
                            <Vertex pos="0.25 -0.25 1" />
                            <Vertex pos="0.25 -0.25 -1" />
                            <Vertex pos="-0.25 0.25 1" />
                            <Vertex pos="-0.25 0.25 -1" />
                            <Vertex pos="-0.25 -0.25 1" />
                            <Vertex pos="-0.25 -0.25 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 448 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -320 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="184" owner="0" type="0" pos="4 1.75 29.75" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 1.75 0 0 1 29.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6.5 0.25 0.25" />
                            <Vertex pos="6.5 0.25 -0.25" />
                            <Vertex pos="6.5 -0.25 0.25" />
                            <Vertex pos="6.5 -0.25 -0.25" />
                            <Vertex pos="-6.5 0.25 0.25" />
                            <Vertex pos="-6.5 0.25 -0.25" />
                            <Vertex pos="-6.5 -0.25 0.25" />
                            <Vertex pos="-6.5 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6.5" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6.5" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 256 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -128 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="185" owner="0" type="0" pos="4 14.25 29.75" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 14.25 0 0 1 29.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6.5 0.25 0.25" />
                            <Vertex pos="6.5 0.25 -0.25" />
                            <Vertex pos="6.5 -0.25 0.25" />
                            <Vertex pos="6.5 -0.25 -0.25" />
                            <Vertex pos="-6.5 0.25 0.25" />
                            <Vertex pos="-6.5 0.25 -0.25" />
                            <Vertex pos="-6.5 -0.25 0.25" />
                            <Vertex pos="-6.5 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6.5" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6.5" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 256 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -128 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="186" owner="0" type="0" pos="-2.25 8 29.75" rot="1 0 0 0" scale="" transform="1 0 0 -2.25 0 1 0 8 0 0 1 29.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 6 0.25" />
                            <Vertex pos="0.25 6 -0.25" />
                            <Vertex pos="0.25 -6 0.25" />
                            <Vertex pos="0.25 -6 -0.25" />
                            <Vertex pos="-0.25 6 0.25" />
                            <Vertex pos="-0.25 6 -0.25" />
                            <Vertex pos="-0.25 -6 0.25" />
                            <Vertex pos="-0.25 -6 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_edge_white" texgens="-1 0 0 1472 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 -1344 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1344 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1472 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="187" owner="0" type="0" pos="10.25 8 29.75" rot="1 0 0 0" scale="" transform="1 0 0 10.25 0 1 0 8 0 0 1 29.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 6 0.25" />
                            <Vertex pos="0.25 6 -0.25" />
                            <Vertex pos="0.25 -6 0.25" />
                            <Vertex pos="0.25 -6 -0.25" />
                            <Vertex pos="-0.25 6 0.25" />
                            <Vertex pos="-0.25 6 -0.25" />
                            <Vertex pos="-0.25 -6 0.25" />
                            <Vertex pos="-0.25 -6 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_edge_white" texgens="-1 0 0 1472 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 -1344 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1344 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1472 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="188" owner="0" type="0" pos="4 3.75 37.75" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 3.75 0 0 1 37.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4.5 0.25 0.25" />
                            <Vertex pos="4.5 0.25 -0.25" />
                            <Vertex pos="4.5 -0.25 0.25" />
                            <Vertex pos="4.5 -0.25 -0.25" />
                            <Vertex pos="-4.5 0.25 0.25" />
                            <Vertex pos="-4.5 0.25 -0.25" />
                            <Vertex pos="-4.5 -0.25 0.25" />
                            <Vertex pos="-4.5 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4.5" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4.5" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 768 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -640 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="189" owner="0" type="0" pos="8.25 8 37.75" rot="1 0 0 0" scale="" transform="1 0 0 8.25 0 1 0 8 0 0 1 37.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4 0.25" />
                            <Vertex pos="0.25 4 -0.25" />
                            <Vertex pos="0.25 -4 0.25" />
                            <Vertex pos="0.25 -4 -0.25" />
                            <Vertex pos="-0.25 4 0.25" />
                            <Vertex pos="-0.25 4 -0.25" />
                            <Vertex pos="-0.25 -4 0.25" />
                            <Vertex pos="-0.25 -4 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1920 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 2048 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 1472 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 -1344 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1344 0 -1 0 2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1472 0 -1 0 2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="190" owner="0" type="0" pos="-0.25 8 37.75" rot="1 0 0 0" scale="" transform="1 0 0 -0.25 0 1 0 8 0 0 1 37.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4 0.25" />
                            <Vertex pos="0.25 4 -0.25" />
                            <Vertex pos="0.25 -4 0.25" />
                            <Vertex pos="0.25 -4 -0.25" />
                            <Vertex pos="-0.25 4 0.25" />
                            <Vertex pos="-0.25 4 -0.25" />
                            <Vertex pos="-0.25 -4 0.25" />
                            <Vertex pos="-0.25 -4 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1920 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 2048 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 1472 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 -1344 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1344 0 -1 0 2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1472 0 -1 0 2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="191" owner="0" type="0" pos="4 12.25 37.75" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 12.25 0 0 1 37.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4.5 0.25 0.25" />
                            <Vertex pos="4.5 0.25 -0.25" />
                            <Vertex pos="4.5 -0.25 0.25" />
                            <Vertex pos="4.5 -0.25 -0.25" />
                            <Vertex pos="-4.5 0.25 0.25" />
                            <Vertex pos="-4.5 0.25 -0.25" />
                            <Vertex pos="-4.5 -0.25 0.25" />
                            <Vertex pos="-4.5 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4.5" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4.5" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 768 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -640 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="192" owner="0" type="0" pos="-24 -37.125 8.25" rot="1 0 0 0" scale="" transform="1 0 0 -24 0 1 0 -37.125 0 0 1 8.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.5 0.125 0.25" />
                            <Vertex pos="2.5 0.125 -0.25" />
                            <Vertex pos="2.5 -0.125 0.25" />
                            <Vertex pos="2.5 -0.125 -0.25" />
                            <Vertex pos="-2.5 0.125 0.25" />
                            <Vertex pos="-2.5 0.125 -0.25" />
                            <Vertex pos="-2.5 -0.125 0.25" />
                            <Vertex pos="-2.5 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2.5" album="" material="bm_trim" texgens="0 1 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2.5" album="" material="bm_trim" texgens="0 -1 0 32 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_trim" texgens="-1 0 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_trim" texgens="1 0 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_trim" texgens="1 0 0 640 0 -1 0 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_trim" texgens="-1 0 0 -512 0 -1 0 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="195" owner="0" type="0" pos="-24.75 26.25 5.5" rot="1 0 0 0" scale="" transform="1 0 0 -24.75 0 1 0 26.25 0 0 1 5.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2.25 0.25" />
                            <Vertex pos="2 2.25 -0.25" />
                            <Vertex pos="2 -0.25 0.25" />
                            <Vertex pos="2 -0.25 -0.25" />
                            <Vertex pos="1.5 2.25 0.25" />
                            <Vertex pos="1.5 2.25 -0.25" />
                            <Vertex pos="1.5 -0.25 0.25" />
                            <Vertex pos="1.5 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank2" texgens="0 1 0 -896 0 0 -1 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 1.5" album="" material="bm_grid_blank2" texgens="0 -1 0 128 0 0 -1 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2.25" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 1024 0 0 -1 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -384 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 1024 0 -1 0 1152 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="196" owner="0" type="0" pos="-24.75 23.75 5.5" rot="1 0 0 0" scale="" transform="1 0 0 -24.75 0 1 0 23.75 0 0 1 5.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2.25 1.25" />
                            <Vertex pos="2 2.25 -0.25" />
                            <Vertex pos="2 -0.25 1.25" />
                            <Vertex pos="2 -0.25 -0.25" />
                            <Vertex pos="1.5 2.25 1.25" />
                            <Vertex pos="1.5 2.25 -0.25" />
                            <Vertex pos="1.5 -0.25 1.25" />
                            <Vertex pos="1.5 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank2" texgens="0 1 0 -204.8 0 0 -1 213.332 0 0.15625 0.1875" texRot="0" texScale="0.15625 0.1875" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 1.5" album="" material="bm_grid_blank2" texgens="0 -1 0 204.8 0 0 -1 213.333 0 0.15625 0.1875" texRot="0" texScale="0.15625 0.1875" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2.25" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 1024 0 0 -1 640 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_beam_metal" texgens="1 0 0 -768 0 0 -1 640 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1.25" album="" material="bm_edge_white" texgens="1 0 0 -384 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 1024 0 -1 0 1152 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="199" owner="0" type="0" pos="-24.75 26.25 6" rot="1 0 0 0" scale="" transform="1 0 0 -24.75 0 1 0 26.25 0 0 1 6 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -0.25 -0.25" />
                            <Vertex pos="1.875 -0.25 0" />
                            <Vertex pos="1.875 2 0" />
                            <Vertex pos="2 2.25 -0.25" />
                            <Vertex pos="1.75 2.25 -0.25" />
                            <Vertex pos="1.75 2 0" />
                            <Vertex pos="1.75 -0.25 0" />
                            <Vertex pos="1.75 -0.25 -0.25" />
                        </Vertices>
                        <Face id="6" plane="0.894427 -0 0.447214 -1.67705" album="Blasted" material="bm_stripe_caution2" texgens="0 1 1 64 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0 0.707107 0.707107 -1.41421" album="Blasted" material="bm_beam_metal" texgens="-1 0 -0.5 960 0 0 -1 0 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="8" plane="-0 -1 -0 -0.25" album="Blasted" material="bm_beam_metal" texgens="1 0 0.5 -704 0 0 -1 0 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="9" plane="0 0 1 -0" album="Blasted" material="bm_beam_metal" texgens="1 0 0 -1664 0 -1 0 2304 0 0.03125 0.03125" texRot="0" texScale="0.03125 0.03125" texDiv="256 256">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="10" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 512 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="11" plane="-1 0 0 1.75" album="" material="bm_edge_white" texgens="0 1 0 512 0 0 1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="200" owner="0" type="0" pos="-24.75 26.25 6" rot="1 0 0 0" scale="" transform="1 0 0 -24.75 0 1 0 26.25 0 0 1 6 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.5 -0.25 -0.25" />
                            <Vertex pos="1.5 2.25 -0.25" />
                            <Vertex pos="1.625 2 0" />
                            <Vertex pos="1.625 -0.25 0" />
                            <Vertex pos="1.75 2.25 -0.25" />
                            <Vertex pos="1.75 2 0" />
                            <Vertex pos="1.75 -0.25 0" />
                            <Vertex pos="1.75 -0.25 -0.25" />
                        </Vertices>
                        <Face id="6" plane="-0.894427 0 0.447214 1.45344" album="Blasted" material="bm_stripe_caution2" texgens="0 -1 1 320 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0 0.707107 0.707107 -1.41421" album="Blasted" material="bm_beam_metal" texgens="-1 0 0.5 1088 0 0 -1 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="8" plane="0 -1 -0 -0.25" album="Blasted" material="bm_beam_metal" texgens="1 0 -0.5 -832 0 0 -1 0 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 0 3 6 7" />
                        </Face>
                        <Face id="9" plane="-0 0 1 -0" album="Blasted" material="bm_beam_metal" texgens="1 0 0 -1664 0 -1 0 2304 0 0.03125 0.03125" texRot="0" texScale="0.03125 0.03125" texDiv="256 256">
                            <Indices indices=" 3 2 5 6" />
                        </Face>
                        <Face id="10" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 512 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="11" plane="1 -0 0 -1.75" album="" material="bm_edge_white" texgens="0 1 0 512 0 0 1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="203" owner="0" type="0" pos="-24.75 23.75 7" rot="1 0 0 0" scale="" transform="1 0 0 -24.75 0 1 0 23.75 0 0 1 7 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -0.25 -0.25" />
                            <Vertex pos="1.875 0 0" />
                            <Vertex pos="1.875 2.25 0" />
                            <Vertex pos="2 2.25 -0.25" />
                            <Vertex pos="1.75 2.25 -0.25" />
                            <Vertex pos="1.75 2.25 0" />
                            <Vertex pos="1.75 0 0" />
                            <Vertex pos="1.75 -0.25 -0.25" />
                        </Vertices>
                        <Face id="6" plane="0.894427 -0 0.447214 -1.67705" album="Blasted" material="bm_stripe_caution2" texgens="0 1 1 128 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0 1 0 -2.25" album="Blasted" material="bm_beam_metal" texgens="-1 0 -0.5 960 0 0 -1 0 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="8" plane="0 -0.707107 0.707107 -0" album="Blasted" material="bm_beam_metal" texgens="1 0 0.5 -704 0 0 -1 0 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="9" plane="0 0 1 -0" album="Blasted" material="bm_beam_metal" texgens="1 0 0 -1664 0 -1 0 2304 0 0.03125 0.03125" texRot="0" texScale="0.03125 0.03125" texDiv="256 256">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="10" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 512 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="11" plane="-1 0 0 1.75" album="" material="bm_edge_white" texgens="0 1 0 512 0 0 1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="204" owner="0" type="0" pos="-24.75 23.75 7" rot="1 0 0 0" scale="" transform="1 0 0 -24.75 0 1 0 23.75 0 0 1 7 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.5 -0.25 -0.25" />
                            <Vertex pos="1.5 2.25 -0.25" />
                            <Vertex pos="1.625 2.25 0" />
                            <Vertex pos="1.625 0 0" />
                            <Vertex pos="1.75 2.25 -0.25" />
                            <Vertex pos="1.75 2.25 0" />
                            <Vertex pos="1.75 0 0" />
                            <Vertex pos="1.75 -0.25 -0.25" />
                        </Vertices>
                        <Face id="6" plane="-0.894427 0 0.447214 1.45344" album="Blasted" material="bm_stripe_caution2" texgens="0 -1 1 256 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0 1 -0 -2.25" album="Blasted" material="bm_beam_metal" texgens="-1 0 0.5 1088 0 0 -1 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="8" plane="0 -0.707107 0.707107 -0" album="Blasted" material="bm_beam_metal" texgens="1 0 -0.5 -832 0 0 -1 0 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 0 3 6 7" />
                        </Face>
                        <Face id="9" plane="-0 0 1 -0" album="Blasted" material="bm_beam_metal" texgens="1 0 0 -1664 0 -1 0 2304 0 0.03125 0.03125" texRot="0" texScale="0.03125 0.03125" texDiv="256 256">
                            <Indices indices=" 3 2 5 6" />
                        </Face>
                        <Face id="10" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 512 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="11" plane="1 -0 0 -1.75" album="" material="bm_edge_white" texgens="0 1 0 512 0 0 1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="205" owner="0" type="0" pos="-16.75 23.75 4.375" rot="1 0 0 0" scale="" transform="1 0 0 -16.75 0 1 0 23.75 0 0 1 4.375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2.25 0.25" />
                            <Vertex pos="2 2.25 -0.25" />
                            <Vertex pos="2 -0.25 0.25" />
                            <Vertex pos="2 -0.25 -0.25" />
                            <Vertex pos="1.5 2.25 0.25" />
                            <Vertex pos="1.5 2.25 -0.25" />
                            <Vertex pos="1.5 -0.25 0.25" />
                            <Vertex pos="1.5 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank2" texgens="0 1 0 -896 0 0 -1 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 1.5" album="" material="bm_grid_blank2" texgens="0 -1 0 128 0 0 -1 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2.25" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 1024 0 0 -1 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_beam_metal" texgens="1 0 0 -768 0 0 -1 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -384 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 1024 0 -1 0 1152 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="206" owner="0" type="0" pos="-16.75 26.25 4.375" rot="1 0 0 0" scale="" transform="1 0 0 -16.75 0 1 0 26.25 0 0 1 4.375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2.25 1.25" />
                            <Vertex pos="2 2.25 -0.25" />
                            <Vertex pos="2 -0.25 1.25" />
                            <Vertex pos="2 -0.25 -0.25" />
                            <Vertex pos="1.5 2.25 1.25" />
                            <Vertex pos="1.5 2.25 -0.25" />
                            <Vertex pos="1.5 -0.25 1.25" />
                            <Vertex pos="1.5 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank2" texgens="0 1 0 -204.8 0 0 -1 213.332 0 0.15625 0.1875" texRot="0" texScale="0.15625 0.1875" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 1.5" album="" material="bm_grid_blank2" texgens="0 -1 0 204.8 0 0 -1 213.333 0 0.15625 0.1875" texRot="0" texScale="0.15625 0.1875" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2.25" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 1024 0 0 -1 640 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_beam_metal" texgens="1 0 0 -768 0 0 -1 640 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1.25" album="" material="bm_edge_white" texgens="1 0 0 -384 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 1024 0 -1 0 1152 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="207" owner="0" type="0" pos="-16.75 26.25 5.875" rot="1 0 0 0" scale="" transform="1 0 0 -16.75 0 1 0 26.25 0 0 1 5.875 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -0.25 -0.25" />
                            <Vertex pos="1.875 -0.25 0" />
                            <Vertex pos="1.875 2 0" />
                            <Vertex pos="2 2.25 -0.25" />
                            <Vertex pos="1.75 2.25 -0.25" />
                            <Vertex pos="1.75 2 0" />
                            <Vertex pos="1.75 -0.25 0" />
                            <Vertex pos="1.75 -0.25 -0.25" />
                        </Vertices>
                        <Face id="6" plane="0.894427 -0 0.447214 -1.67705" album="Blasted" material="bm_stripe_caution2" texgens="0 1 1 64 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0 0.707107 0.707107 -1.41421" album="Blasted" material="bm_beam_metal" texgens="-1 0 -0.5 960 0 0 -1 0 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="8" plane="-0 -1 -0 -0.25" album="Blasted" material="bm_beam_metal" texgens="1 0 0.5 -704 0 0 -1 0 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="9" plane="0 0 1 -0" album="Blasted" material="bm_beam_metal" texgens="1 0 0 -1664 0 -1 0 2304 0 0.03125 0.03125" texRot="0" texScale="0.03125 0.03125" texDiv="256 256">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="10" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 512 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="11" plane="-1 0 0 1.75" album="" material="bm_edge_white" texgens="0 1 0 512 0 0 1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="208" owner="0" type="0" pos="-16.75 26.25 5.875" rot="1 0 0 0" scale="" transform="1 0 0 -16.75 0 1 0 26.25 0 0 1 5.875 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.5 -0.25 -0.25" />
                            <Vertex pos="1.5 2.25 -0.25" />
                            <Vertex pos="1.625 2 0" />
                            <Vertex pos="1.625 -0.25 0" />
                            <Vertex pos="1.75 2.25 -0.25" />
                            <Vertex pos="1.75 2 0" />
                            <Vertex pos="1.75 -0.25 0" />
                            <Vertex pos="1.75 -0.25 -0.25" />
                        </Vertices>
                        <Face id="6" plane="-0.894427 0 0.447214 1.45344" album="Blasted" material="bm_stripe_caution2" texgens="0 -1 1 320 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0 0.707107 0.707107 -1.41421" album="Blasted" material="bm_beam_metal" texgens="-1 0 0.5 1088 0 0 -1 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="8" plane="0 -1 -0 -0.25" album="Blasted" material="bm_beam_metal" texgens="1 0 -0.5 -832 0 0 -1 0 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 0 3 6 7" />
                        </Face>
                        <Face id="9" plane="-0 0 1 -0" album="Blasted" material="bm_beam_metal" texgens="1 0 0 -1664 0 -1 0 2304 0 0.03125 0.03125" texRot="0" texScale="0.03125 0.03125" texDiv="256 256">
                            <Indices indices=" 3 2 5 6" />
                        </Face>
                        <Face id="10" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 512 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="11" plane="1 -0 0 -1.75" album="" material="bm_edge_white" texgens="0 1 0 512 0 0 1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="209" owner="0" type="0" pos="-16.75 23.75 4.875" rot="1 0 0 0" scale="" transform="1 0 0 -16.75 0 1 0 23.75 0 0 1 4.875 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -0.25 -0.25" />
                            <Vertex pos="1.875 0 0" />
                            <Vertex pos="1.875 2.25 0" />
                            <Vertex pos="2 2.25 -0.25" />
                            <Vertex pos="1.75 2.25 -0.25" />
                            <Vertex pos="1.75 2.25 0" />
                            <Vertex pos="1.75 0 0" />
                            <Vertex pos="1.75 -0.25 -0.25" />
                        </Vertices>
                        <Face id="6" plane="0.894427 -0 0.447214 -1.67705" album="Blasted" material="bm_stripe_caution2" texgens="0 1 1 128 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0 1 0 -2.25" album="Blasted" material="bm_beam_metal" texgens="-1 0 -0.5 960 0 0 -1 0 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="8" plane="0 -0.707107 0.707107 -0" album="Blasted" material="bm_beam_metal" texgens="1 0 0.5 -704 0 0 -1 0 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="9" plane="0 0 1 -0" album="Blasted" material="bm_beam_metal" texgens="1 0 0 -1664 0 -1 0 2304 0 0.03125 0.03125" texRot="0" texScale="0.03125 0.03125" texDiv="256 256">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="10" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 512 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="11" plane="-1 0 0 1.75" album="" material="bm_edge_white" texgens="0 1 0 512 0 0 1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="210" owner="0" type="0" pos="-16.75 23.75 4.875" rot="1 0 0 0" scale="" transform="1 0 0 -16.75 0 1 0 23.75 0 0 1 4.875 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.5 -0.25 -0.25" />
                            <Vertex pos="1.5 2.25 -0.25" />
                            <Vertex pos="1.625 2.25 0" />
                            <Vertex pos="1.625 0 0" />
                            <Vertex pos="1.75 2.25 -0.25" />
                            <Vertex pos="1.75 2.25 0" />
                            <Vertex pos="1.75 0 0" />
                            <Vertex pos="1.75 -0.25 -0.25" />
                        </Vertices>
                        <Face id="6" plane="-0.894427 0 0.447214 1.45344" album="Blasted" material="bm_stripe_caution2" texgens="0 -1 1 256 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0 1 -0 -2.25" album="Blasted" material="bm_beam_metal" texgens="-1 0 0.5 1088 0 0 -1 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="8" plane="0 -0.707107 0.707107 -0" album="Blasted" material="bm_beam_metal" texgens="1 0 -0.5 -832 0 0 -1 0 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 0 3 6 7" />
                        </Face>
                        <Face id="9" plane="-0 0 1 -0" album="Blasted" material="bm_beam_metal" texgens="1 0 0 -1664 0 -1 0 2304 0 0.03125 0.03125" texRot="0" texScale="0.03125 0.03125" texDiv="256 256">
                            <Indices indices=" 3 2 5 6" />
                        </Face>
                        <Face id="10" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 512 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="11" plane="1 -0 0 -1.75" album="" material="bm_edge_white" texgens="0 1 0 512 0 0 1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="211" owner="0" type="0" pos="-4.75 -26.75 11" rot="1 0 0 0" scale="" transform="1 0 0 -4.75 0 1 0 -26.75 0 0 1 11 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2.25 0.25" />
                            <Vertex pos="2 2.25 -0.25" />
                            <Vertex pos="2 -0.25 0.25" />
                            <Vertex pos="2 -0.25 -0.25" />
                            <Vertex pos="1.5 2.25 0.25" />
                            <Vertex pos="1.5 2.25 -0.25" />
                            <Vertex pos="1.5 -0.25 0.25" />
                            <Vertex pos="1.5 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank2" texgens="0 1 0 -896 0 0 -1 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 1.5" album="" material="bm_grid_blank2" texgens="0 -1 0 128 0 0 -1 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2.25" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 1024 0 0 -1 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -384 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 1024 0 -1 0 1152 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="212" owner="0" type="0" pos="-4.75 -29.25 11" rot="1 0 0 0" scale="" transform="1 0 0 -4.75 0 1 0 -29.25 0 0 1 11 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2.25 1.25" />
                            <Vertex pos="2 2.25 -0.25" />
                            <Vertex pos="2 -0.25 1.25" />
                            <Vertex pos="2 -0.25 -0.25" />
                            <Vertex pos="1.5 2.25 1.25" />
                            <Vertex pos="1.5 2.25 -0.25" />
                            <Vertex pos="1.5 -0.25 1.25" />
                            <Vertex pos="1.5 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank2" texgens="0 1 0 -204.8 0 0 -1 213.332 0 0.15625 0.1875" texRot="0" texScale="0.15625 0.1875" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 1.5" album="" material="bm_grid_blank2" texgens="0 -1 0 204.8 0 0 -1 213.333 0 0.15625 0.1875" texRot="0" texScale="0.15625 0.1875" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2.25" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 1024 0 0 -1 640 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_beam_metal" texgens="1 0 0 -768 0 0 -1 640 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1.25" album="" material="bm_edge_white" texgens="1 0 0 -384 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 1024 0 -1 0 1152 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="213" owner="0" type="0" pos="-4.75 -26.75 11.5" rot="1 0 0 0" scale="" transform="1 0 0 -4.75 0 1 0 -26.75 0 0 1 11.5 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -0.25 -0.25" />
                            <Vertex pos="1.875 -0.25 0" />
                            <Vertex pos="1.875 2 0" />
                            <Vertex pos="2 2.25 -0.25" />
                            <Vertex pos="1.75 2.25 -0.25" />
                            <Vertex pos="1.75 2 0" />
                            <Vertex pos="1.75 -0.25 0" />
                            <Vertex pos="1.75 -0.25 -0.25" />
                        </Vertices>
                        <Face id="6" plane="0.894427 -0 0.447214 -1.67705" album="Blasted" material="bm_stripe_caution2" texgens="0 1 1 64 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0 0.707107 0.707107 -1.41421" album="Blasted" material="bm_beam_metal" texgens="-1 0 -0.5 960 0 0 -1 0 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="8" plane="-0 -1 -0 -0.25" album="Blasted" material="bm_beam_metal" texgens="1 0 0.5 -704 0 0 -1 0 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="9" plane="0 0 1 -0" album="Blasted" material="bm_beam_metal" texgens="1 0 0 -1664 0 -1 0 2304 0 0.03125 0.03125" texRot="0" texScale="0.03125 0.03125" texDiv="256 256">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="10" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 512 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="11" plane="-1 0 0 1.75" album="" material="bm_edge_white" texgens="0 1 0 512 0 0 1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="214" owner="0" type="0" pos="-4.75 -26.75 11.5" rot="1 0 0 0" scale="" transform="1 0 0 -4.75 0 1 0 -26.75 0 0 1 11.5 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.5 -0.25 -0.25" />
                            <Vertex pos="1.5 2.25 -0.25" />
                            <Vertex pos="1.625 2 0" />
                            <Vertex pos="1.625 -0.25 0" />
                            <Vertex pos="1.75 2.25 -0.25" />
                            <Vertex pos="1.75 2 0" />
                            <Vertex pos="1.75 -0.25 0" />
                            <Vertex pos="1.75 -0.25 -0.25" />
                        </Vertices>
                        <Face id="6" plane="-0.894427 0 0.447214 1.45344" album="Blasted" material="bm_stripe_caution2" texgens="0 -1 1 320 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0 0.707107 0.707107 -1.41421" album="Blasted" material="bm_beam_metal" texgens="-1 0 0.5 1088 0 0 -1 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="8" plane="0 -1 -0 -0.25" album="Blasted" material="bm_beam_metal" texgens="1 0 -0.5 -832 0 0 -1 0 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 0 3 6 7" />
                        </Face>
                        <Face id="9" plane="-0 0 1 -0" album="Blasted" material="bm_beam_metal" texgens="1 0 0 -1664 0 -1 0 2304 0 0.03125 0.03125" texRot="0" texScale="0.03125 0.03125" texDiv="256 256">
                            <Indices indices=" 3 2 5 6" />
                        </Face>
                        <Face id="10" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 512 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="11" plane="1 -0 0 -1.75" album="" material="bm_edge_white" texgens="0 1 0 512 0 0 1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="215" owner="0" type="0" pos="-4.75 -29.25 12.5" rot="1 0 0 0" scale="" transform="1 0 0 -4.75 0 1 0 -29.25 0 0 1 12.5 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -0.25 -0.25" />
                            <Vertex pos="1.875 0 0" />
                            <Vertex pos="1.875 2.25 0" />
                            <Vertex pos="2 2.25 -0.25" />
                            <Vertex pos="1.75 2.25 -0.25" />
                            <Vertex pos="1.75 2.25 0" />
                            <Vertex pos="1.75 0 0" />
                            <Vertex pos="1.75 -0.25 -0.25" />
                        </Vertices>
                        <Face id="6" plane="0.894427 -0 0.447214 -1.67705" album="Blasted" material="bm_stripe_caution2" texgens="0 1 1 128 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0 1 0 -2.25" album="Blasted" material="bm_beam_metal" texgens="-1 0 -0.5 960 0 0 -1 0 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="8" plane="0 -0.707107 0.707107 -0" album="Blasted" material="bm_beam_metal" texgens="1 0 0.5 -704 0 0 -1 0 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="9" plane="0 0 1 -0" album="Blasted" material="bm_beam_metal" texgens="1 0 0 -1664 0 -1 0 2304 0 0.03125 0.03125" texRot="0" texScale="0.03125 0.03125" texDiv="256 256">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="10" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 512 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="11" plane="-1 0 0 1.75" album="" material="bm_edge_white" texgens="0 1 0 512 0 0 1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="216" owner="0" type="0" pos="-4.75 -29.25 12.5" rot="1 0 0 0" scale="" transform="1 0 0 -4.75 0 1 0 -29.25 0 0 1 12.5 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.5 -0.25 -0.25" />
                            <Vertex pos="1.5 2.25 -0.25" />
                            <Vertex pos="1.625 2.25 0" />
                            <Vertex pos="1.625 0 0" />
                            <Vertex pos="1.75 2.25 -0.25" />
                            <Vertex pos="1.75 2.25 0" />
                            <Vertex pos="1.75 0 0" />
                            <Vertex pos="1.75 -0.25 -0.25" />
                        </Vertices>
                        <Face id="6" plane="-0.894427 0 0.447214 1.45344" album="Blasted" material="bm_stripe_caution2" texgens="0 -1 1 256 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0 1 -0 -2.25" album="Blasted" material="bm_beam_metal" texgens="-1 0 0.5 1088 0 0 -1 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="8" plane="0 -0.707107 0.707107 -0" album="Blasted" material="bm_beam_metal" texgens="1 0 -0.5 -832 0 0 -1 0 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 0 3 6 7" />
                        </Face>
                        <Face id="9" plane="-0 0 1 -0" album="Blasted" material="bm_beam_metal" texgens="1 0 0 -1664 0 -1 0 2304 0 0.03125 0.03125" texRot="0" texScale="0.03125 0.03125" texDiv="256 256">
                            <Indices indices=" 3 2 5 6" />
                        </Face>
                        <Face id="10" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 512 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="11" plane="1 -0 0 -1.75" album="" material="bm_edge_white" texgens="0 1 0 512 0 0 1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="217" owner="0" type="0" pos="-10.75 -29.25 9.75" rot="1 0 0 0" scale="" transform="1 0 0 -10.75 0 1 0 -29.25 0 0 1 9.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2.25 0.25" />
                            <Vertex pos="2 2.25 -0.25" />
                            <Vertex pos="2 -0.25 0.25" />
                            <Vertex pos="2 -0.25 -0.25" />
                            <Vertex pos="1.5 2.25 0.25" />
                            <Vertex pos="1.5 2.25 -0.25" />
                            <Vertex pos="1.5 -0.25 0.25" />
                            <Vertex pos="1.5 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank2" texgens="0 1 0 -896 0 0 -1 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 1.5" album="" material="bm_grid_blank2" texgens="0 -1 0 128 0 0 -1 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2.25" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 1024 0 0 -1 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_beam_metal" texgens="1 0 0 -768 0 0 -1 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -384 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 1024 0 -1 0 1152 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="218" owner="0" type="0" pos="-10.75 -26.75 9.75" rot="1 0 0 0" scale="" transform="1 0 0 -10.75 0 1 0 -26.75 0 0 1 9.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2.25 1.25" />
                            <Vertex pos="2 2.25 -0.25" />
                            <Vertex pos="2 -0.25 1.25" />
                            <Vertex pos="2 -0.25 -0.25" />
                            <Vertex pos="1.5 2.25 1.25" />
                            <Vertex pos="1.5 2.25 -0.25" />
                            <Vertex pos="1.5 -0.25 1.25" />
                            <Vertex pos="1.5 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank2" texgens="0 1 0 -204.8 0 0 -1 213.332 0 0.15625 0.1875" texRot="0" texScale="0.15625 0.1875" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 1.5" album="" material="bm_grid_blank2" texgens="0 -1 0 204.8 0 0 -1 213.333 0 0.15625 0.1875" texRot="0" texScale="0.15625 0.1875" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2.25" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 1024 0 0 -1 640 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_beam_metal" texgens="1 0 0 -768 0 0 -1 640 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1.25" album="" material="bm_edge_white" texgens="1 0 0 -384 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_beam_metal" texgens="-1 0 0 1024 0 -1 0 1152 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="219" owner="0" type="0" pos="-10.75 -26.75 11.25" rot="1 0 0 0" scale="" transform="1 0 0 -10.75 0 1 0 -26.75 0 0 1 11.25 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -0.25 -0.25" />
                            <Vertex pos="1.875 -0.25 0" />
                            <Vertex pos="1.875 2 0" />
                            <Vertex pos="2 2.25 -0.25" />
                            <Vertex pos="1.75 2.25 -0.25" />
                            <Vertex pos="1.75 2 0" />
                            <Vertex pos="1.75 -0.25 0" />
                            <Vertex pos="1.75 -0.25 -0.25" />
                        </Vertices>
                        <Face id="6" plane="0.894427 -0 0.447214 -1.67705" album="Blasted" material="bm_stripe_caution2" texgens="0 1 1 64 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0 0.707107 0.707107 -1.41421" album="Blasted" material="bm_beam_metal" texgens="-1 0 -0.5 960 0 0 -1 0 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="8" plane="-0 -1 -0 -0.25" album="Blasted" material="bm_beam_metal" texgens="1 0 0.5 -704 0 0 -1 0 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="9" plane="0 0 1 -0" album="Blasted" material="bm_beam_metal" texgens="1 0 0 -1664 0 -1 0 2304 0 0.03125 0.03125" texRot="0" texScale="0.03125 0.03125" texDiv="256 256">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="10" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 512 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="11" plane="-1 0 0 1.75" album="" material="bm_edge_white" texgens="0 1 0 512 0 0 1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="220" owner="0" type="0" pos="-10.75 -26.75 11.25" rot="1 0 0 0" scale="" transform="1 0 0 -10.75 0 1 0 -26.75 0 0 1 11.25 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.5 -0.25 -0.25" />
                            <Vertex pos="1.5 2.25 -0.25" />
                            <Vertex pos="1.625 2 0" />
                            <Vertex pos="1.625 -0.25 0" />
                            <Vertex pos="1.75 2.25 -0.25" />
                            <Vertex pos="1.75 2 0" />
                            <Vertex pos="1.75 -0.25 0" />
                            <Vertex pos="1.75 -0.25 -0.25" />
                        </Vertices>
                        <Face id="6" plane="-0.894427 0 0.447214 1.45344" album="Blasted" material="bm_stripe_caution2" texgens="0 -1 1 320 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0 0.707107 0.707107 -1.41421" album="Blasted" material="bm_beam_metal" texgens="-1 0 0.5 1088 0 0 -1 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="8" plane="0 -1 -0 -0.25" album="Blasted" material="bm_beam_metal" texgens="1 0 -0.5 -832 0 0 -1 0 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 0 3 6 7" />
                        </Face>
                        <Face id="9" plane="-0 0 1 -0" album="Blasted" material="bm_beam_metal" texgens="1 0 0 -1664 0 -1 0 2304 0 0.03125 0.03125" texRot="0" texScale="0.03125 0.03125" texDiv="256 256">
                            <Indices indices=" 3 2 5 6" />
                        </Face>
                        <Face id="10" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 512 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="11" plane="1 -0 0 -1.75" album="" material="bm_edge_white" texgens="0 1 0 512 0 0 1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="221" owner="0" type="0" pos="-10.75 -29.25 10.25" rot="1 0 0 0" scale="" transform="1 0 0 -10.75 0 1 0 -29.25 0 0 1 10.25 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -0.25 -0.25" />
                            <Vertex pos="1.875 0 0" />
                            <Vertex pos="1.875 2.25 0" />
                            <Vertex pos="2 2.25 -0.25" />
                            <Vertex pos="1.75 2.25 -0.25" />
                            <Vertex pos="1.75 2.25 0" />
                            <Vertex pos="1.75 0 0" />
                            <Vertex pos="1.75 -0.25 -0.25" />
                        </Vertices>
                        <Face id="6" plane="0.894427 -0 0.447214 -1.67705" album="Blasted" material="bm_stripe_caution2" texgens="0 1 1 128 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0 1 0 -2.25" album="Blasted" material="bm_beam_metal" texgens="-1 0 -0.5 960 0 0 -1 0 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="8" plane="0 -0.707107 0.707107 -0" album="Blasted" material="bm_beam_metal" texgens="1 0 0.5 -704 0 0 -1 0 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="9" plane="0 0 1 -0" album="Blasted" material="bm_beam_metal" texgens="1 0 0 -1664 0 -1 0 2304 0 0.03125 0.03125" texRot="0" texScale="0.03125 0.03125" texDiv="256 256">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="10" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 512 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="11" plane="-1 0 0 1.75" album="" material="bm_edge_white" texgens="0 1 0 512 0 0 1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="222" owner="0" type="0" pos="-10.75 -29.25 10.25" rot="1 0 0 0" scale="" transform="1 0 0 -10.75 0 1 0 -29.25 0 0 1 10.25 0 0 0 1" group="-1" locked="0" nextFaceID="13" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.5 -0.25 -0.25" />
                            <Vertex pos="1.5 2.25 -0.25" />
                            <Vertex pos="1.625 2.25 0" />
                            <Vertex pos="1.625 0 0" />
                            <Vertex pos="1.75 2.25 -0.25" />
                            <Vertex pos="1.75 2.25 0" />
                            <Vertex pos="1.75 0 0" />
                            <Vertex pos="1.75 -0.25 -0.25" />
                        </Vertices>
                        <Face id="6" plane="-0.894427 0 0.447214 1.45344" album="Blasted" material="bm_stripe_caution2" texgens="0 -1 1 256 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="7" plane="0 1 -0 -2.25" album="Blasted" material="bm_beam_metal" texgens="-1 0 0.5 1088 0 0 -1 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="8" plane="0 -0.707107 0.707107 -0" album="Blasted" material="bm_beam_metal" texgens="1 0 -0.5 -832 0 0 -1 0 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 0 3 6 7" />
                        </Face>
                        <Face id="9" plane="-0 0 1 -0" album="Blasted" material="bm_beam_metal" texgens="1 0 0 -1664 0 -1 0 2304 0 0.03125 0.03125" texRot="0" texScale="0.03125 0.03125" texDiv="256 256">
                            <Indices indices=" 3 2 5 6" />
                        </Face>
                        <Face id="10" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 512 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="11" plane="1 -0 0 -1.75" album="" material="bm_edge_white" texgens="0 1 0 512 0 0 1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="223" owner="26" type="4" pos="11 8 6.25" rot="1 0 0 0" scale="" transform="1 0 0 11 0 1 0 8 0 0 1 6.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 0.25" />
                            <Vertex pos="1 2 -0.25" />
                            <Vertex pos="1 -2 0.25" />
                            <Vertex pos="1 -2 -0.25" />
                            <Vertex pos="-1 2 0.25" />
                            <Vertex pos="-1 2 -0.25" />
                            <Vertex pos="-1 -2 0.25" />
                            <Vertex pos="-1 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 256 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 128 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="224" owner="0" type="0" pos="-8 -42 -10" rot="1 0 0 0" scale="" transform="1 0 0 -8 0 1 0 -42 0 0 1 -10 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="17">
                        <Vertices>
                            <Vertex pos="2.12132 2.12125 -6" />
                            <Vertex pos="2.12132 2.12125 2" />
                            <Vertex pos="3 3.8147e-006 -6" />
                            <Vertex pos="3 3.8147e-006 2" />
                            <Vertex pos="-9.05991e-006 3 -6" />
                            <Vertex pos="-9.53674e-006 3 2" />
                            <Vertex pos="-2.12132 2.12125 -6" />
                            <Vertex pos="-2.12132 2.12125 2" />
                            <Vertex pos="-3 7.62939e-006 -6" />
                            <Vertex pos="-3 7.62939e-006 2" />
                            <Vertex pos="-2.12131 -2.12125 -6" />
                            <Vertex pos="-2.12131 -2.12125 2" />
                            <Vertex pos="4.76837e-006 -3 -6" />
                            <Vertex pos="4.76837e-006 -3 2" />
                            <Vertex pos="2.12134 -2.12126 -6" />
                            <Vertex pos="2.12134 -2.12126 2" />
                        </Vertices>
                        <Face id="0" plane="0.923875 0.382695 0 -2.77163" album="" material="bm_grid_blank1" texgens="-0.382684 0.92388 0 127.988 0 0 -1 768 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0.382708 0.923869 2.28109e-008 -2.7716" album="" material="bm_grid_blank1" texgens="-0.92388 0.382682 0 128.003 0 0 -1 768 0 0.287014 0.25" texRot="0" texScale="0.287014 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="-0.382711 0.923868 0 -2.77161" album="" material="bm_grid_blank1" texgens="-0.92388 -0.382683 0 128.006 0 0 -1 768 0 0.28701 0.25" texRot="0" texScale="0.28701 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="3" plane="-0.923875 0.382696 0 -2.77163" album="" material="bm_grid_blank1" texgens="-0.382687 -0.923878 0 128.014 0 0 -1 768 0 0.287014 0.25" texRot="0" texScale="0.287014 0.25" texDiv="256 256">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="4" plane="-0.923874 -0.382697 0 -2.77162" album="" material="bm_grid_blank1" texgens="0.382682 -0.92388 0 127.979 0 0 -1 768 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="5" plane="-0.38271 -0.923868 0 -2.7716" album="" material="bm_grid_blank1" texgens="0.92388 -0.382683 0 128.003 0 0 -1 768 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="6" plane="0.382704 -0.923871 0 -2.77162" album="" material="bm_grid_blank1" texgens="0.923878 0.382686 0 127.998 0 0 -1 768 0 0.287014 0.25" texRot="0" texScale="0.287014 0.25" texDiv="256 256">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="7" plane="0.923879 -0.382685 0 -2.77164" album="" material="bm_grid_blank1" texgens="0.382681 0.92388 0 128.025 0 0 -1 768 0 0.287011 0.25" texRot="0" texScale="0.287011 0.25" texDiv="256 256">
                            <Indices indices=" 15 3 2 14" />
                        </Face>
                        <Face id="8" plane="-0 0 -1 -6" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 14 2 0 4 6 8 10 12" />
                        </Face>
                        <Face id="9" plane="0 -0 1 -2" album="" material="bm_friction_grass" texgens="1 0 0 -1024 0 -1 0 5376 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="225" owner="0" type="0" pos="-8 -42 3" rot="1 0 0 0" scale="" transform="1 0 0 -8 0 1 0 -42 0 0 1 3 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="33">
                        <Vertices>
                            <Vertex pos="0.692907 0.286877 -11" />
                            <Vertex pos="0.692909 0.286877 15" />
                            <Vertex pos="0.75 0 -11" />
                            <Vertex pos="0.75 0 15" />
                            <Vertex pos="0.530345 0.530308 -11" />
                            <Vertex pos="0.530346 0.530308 15" />
                            <Vertex pos="0.286971 0.69281 -11" />
                            <Vertex pos="0.286972 0.69281 15" />
                            <Vertex pos="2.47955e-005 0.75 -11" />
                            <Vertex pos="2.28882e-005 0.75 15" />
                            <Vertex pos="-0.287071 0.692814 -11" />
                            <Vertex pos="-0.287071 0.692814 15" />
                            <Vertex pos="-0.530313 0.530315 -11" />
                            <Vertex pos="-0.530312 0.530315 15" />
                            <Vertex pos="-0.692904 0.286884 -11" />
                            <Vertex pos="-0.692905 0.286884 15" />
                            <Vertex pos="-0.75 0 -11" />
                            <Vertex pos="-0.75 0 15" />
                            <Vertex pos="-0.692907 -0.286873 -11" />
                            <Vertex pos="-0.692909 -0.286873 15" />
                            <Vertex pos="-0.530376 -0.530308 -11" />
                            <Vertex pos="-0.530376 -0.530308 15" />
                            <Vertex pos="-0.286956 -0.692818 -11" />
                            <Vertex pos="-0.286957 -0.692818 15" />
                            <Vertex pos="1.00136e-005 -0.750004 -11" />
                            <Vertex pos="7.62939e-006 -0.750004 15" />
                            <Vertex pos="0.286997 -0.692822 -11" />
                            <Vertex pos="0.286995 -0.692822 15" />
                            <Vertex pos="0.53034 -0.530319 -11" />
                            <Vertex pos="0.530342 -0.530319 15" />
                            <Vertex pos="0.692906 -0.28688 -11" />
                            <Vertex pos="0.692905 -0.28688 15" />
                        </Vertices>
                        <Face id="0" plane="0.980767 0.195181 -8.29781e-008 -0.735574" album="" material="solid_bm" texgens="-0.195089 0.980786 0 4.6792 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0.831617 0.55535 -2.35045e-008 -0.735551" album="" material="solid_bm" texgens="-0.555572 0.831468 0 14.0393 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0.555298 0.831652 -2.41843e-008 -0.735531" album="" material="solid_bm" texgens="-0.831471 0.555569 0 23.4103 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="3" plane="0.195461 0.980711 1.43387e-008 -0.735538" album="" material="solid_bm" texgens="-0.980786 0.195088 0 32.7745 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="4" plane="-0.19535 0.980734 2.70529e-009 -0.735545" album="" material="solid_bm" texgens="-0.980784 -0.195095 0 42.1397 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="5" plane="-0.555499 0.831517 1.72197e-008 -0.735554" album="" material="solid_bm" texgens="-0.831471 -0.555568 0 51.5062 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="6" plane="-0.831571 0.555418 -5.21192e-008 -0.73554" album="" material="solid_bm" texgens="-0.555573 -0.831468 0 60.8636 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="7" plane="-0.980765 0.195193 0 -0.735574" album="" material="solid_bm" texgens="-0.195092 -0.980785 0 70.2384 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 17 16 14 15" />
                        </Face>
                        <Face id="8" plane="-0.980765 -0.19519 -8.43202e-008 -0.735575" album="" material="solid_bm" texgens="0.195089 -0.980786 0 79.6007 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 19 18 16 17" />
                        </Face>
                        <Face id="9" plane="-0.83167 -0.55527 -8.25435e-009 -0.735562" album="" material="solid_bm" texgens="0.555567 -0.831472 0 88.9565 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 21 20 18 19" />
                        </Face>
                        <Face id="10" plane="-0.555244 -0.831688 -7.0144e-009 -0.735539" album="" material="solid_bm" texgens="0.831471 -0.555569 0 98.3286 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 23 22 20 21" />
                        </Face>
                        <Face id="11" plane="-0.195435 -0.980717 -1.11766e-008 -0.73554" album="" material="solid_bm" texgens="0.980786 -0.195089 0 107.69 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 25 24 22 23" />
                        </Face>
                        <Face id="12" plane="0.195408 -0.980722 3.34413e-008 -0.735547" album="" material="solid_bm" texgens="0.980785 0.195092 0 117.055 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 27 26 24 25" />
                        </Face>
                        <Face id="13" plane="0.555349 -0.831617 -5.21854e-008 -0.735547" album="" material="solid_bm" texgens="0.831468 0.555572 0 126.421 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 29 28 26 27" />
                        </Face>
                        <Face id="14" plane="0.831619 -0.555346 2.3495e-008 -0.735551" album="" material="solid_bm" texgens="0.555569 0.83147 0 135.786 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 30 28 29" />
                        </Face>
                        <Face id="15" plane="0.980765 -0.195192 0 -0.735574" album="" material="solid_bm" texgens="0.195087 0.980786 0 145.144 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 3 2 30" />
                        </Face>
                        <Face id="16" plane="-0 0 -1 -11" album="" material="solid_bm" texgens="-1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 30 2 0 4 6 8 10 12 14 16 18 20 22 24 26 28" />
                        </Face>
                        <Face id="17" plane="0 -0 1 -15" album="" material="solid_bm" texgens="1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 29 27 25 23 21 19 17 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="226" owner="0" type="0" pos="-48 0 -10" rot="1 0 0 0" scale="" transform="1 0 0 -48 0 1 0 0 0 0 1 -10 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="17">
                        <Vertices>
                            <Vertex pos="2.12132 2.12125 -6" />
                            <Vertex pos="2.12132 2.12125 2" />
                            <Vertex pos="3 3.8147e-006 -6" />
                            <Vertex pos="3 3.8147e-006 2" />
                            <Vertex pos="-9.05991e-006 3 -6" />
                            <Vertex pos="-9.53674e-006 3 2" />
                            <Vertex pos="-2.12132 2.12125 -6" />
                            <Vertex pos="-2.12132 2.12125 2" />
                            <Vertex pos="-3 7.62939e-006 -6" />
                            <Vertex pos="-3 7.62939e-006 2" />
                            <Vertex pos="-2.12131 -2.12125 -6" />
                            <Vertex pos="-2.12131 -2.12125 2" />
                            <Vertex pos="4.76837e-006 -3 -6" />
                            <Vertex pos="4.76837e-006 -3 2" />
                            <Vertex pos="2.12134 -2.12126 -6" />
                            <Vertex pos="2.12134 -2.12126 2" />
                        </Vertices>
                        <Face id="0" plane="0.923875 0.382695 0 -2.77163" album="" material="bm_grid_blank1" texgens="-0.382684 0.92388 0 127.988 0 0 -1 768 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0.382708 0.923869 2.28109e-008 -2.7716" album="" material="bm_grid_blank1" texgens="-0.92388 0.382682 0 128.003 0 0 -1 768 0 0.287014 0.25" texRot="0" texScale="0.287014 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="-0.382711 0.923868 0 -2.77161" album="" material="bm_grid_blank1" texgens="-0.92388 -0.382683 0 128.006 0 0 -1 768 0 0.28701 0.25" texRot="0" texScale="0.28701 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="3" plane="-0.923875 0.382696 0 -2.77163" album="" material="bm_grid_blank1" texgens="-0.382687 -0.923878 0 128.014 0 0 -1 768 0 0.287014 0.25" texRot="0" texScale="0.287014 0.25" texDiv="256 256">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="4" plane="-0.923874 -0.382697 0 -2.77162" album="" material="bm_grid_blank1" texgens="0.382682 -0.92388 0 127.979 0 0 -1 768 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="5" plane="-0.38271 -0.923868 0 -2.7716" album="" material="bm_grid_blank1" texgens="0.92388 -0.382683 0 128.003 0 0 -1 768 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="6" plane="0.382704 -0.923871 0 -2.77162" album="" material="bm_grid_blank1" texgens="0.923878 0.382686 0 127.998 0 0 -1 768 0 0.287014 0.25" texRot="0" texScale="0.287014 0.25" texDiv="256 256">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="7" plane="0.923879 -0.382685 0 -2.77164" album="" material="bm_grid_blank1" texgens="0.382681 0.92388 0 128.025 0 0 -1 768 0 0.287011 0.25" texRot="0" texScale="0.287011 0.25" texDiv="256 256">
                            <Indices indices=" 15 3 2 14" />
                        </Face>
                        <Face id="8" plane="-0 0 -1 -6" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 14 2 0 4 6 8 10 12" />
                        </Face>
                        <Face id="9" plane="0 -0 1 -2" album="" material="bm_friction_grass" texgens="1 0 0 -6144 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="227" owner="0" type="0" pos="-48 0 3" rot="1 0 0 0" scale="" transform="1 0 0 -48 0 1 0 0 0 0 1 3 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="33">
                        <Vertices>
                            <Vertex pos="0.692907 0.286877 -11" />
                            <Vertex pos="0.692909 0.286877 17" />
                            <Vertex pos="0.75 0 -11" />
                            <Vertex pos="0.75 0 17" />
                            <Vertex pos="0.530345 0.530308 -11" />
                            <Vertex pos="0.530346 0.530308 17" />
                            <Vertex pos="0.286971 0.69281 -11" />
                            <Vertex pos="0.286972 0.69281 17" />
                            <Vertex pos="2.47955e-005 0.75 -11" />
                            <Vertex pos="2.28882e-005 0.75 17" />
                            <Vertex pos="-0.287071 0.692814 -11" />
                            <Vertex pos="-0.287071 0.692814 17" />
                            <Vertex pos="-0.530313 0.530315 -11" />
                            <Vertex pos="-0.530312 0.530315 17" />
                            <Vertex pos="-0.692904 0.286884 -11" />
                            <Vertex pos="-0.692905 0.286884 17" />
                            <Vertex pos="-0.75 0 -11" />
                            <Vertex pos="-0.75 0 17" />
                            <Vertex pos="-0.692907 -0.286873 -11" />
                            <Vertex pos="-0.692909 -0.286873 17" />
                            <Vertex pos="-0.530376 -0.530308 -11" />
                            <Vertex pos="-0.530376 -0.530308 17" />
                            <Vertex pos="-0.286956 -0.692818 -11" />
                            <Vertex pos="-0.286957 -0.692818 17" />
                            <Vertex pos="1.00136e-005 -0.750004 -11" />
                            <Vertex pos="7.62939e-006 -0.750004 17" />
                            <Vertex pos="0.286997 -0.692822 -11" />
                            <Vertex pos="0.286995 -0.692822 17" />
                            <Vertex pos="0.53034 -0.530319 -11" />
                            <Vertex pos="0.530342 -0.530319 17" />
                            <Vertex pos="0.692906 -0.28688 -11" />
                            <Vertex pos="0.692905 -0.28688 17" />
                        </Vertices>
                        <Face id="0" plane="0.980767 0.195181 -7.09851e-008 -0.735574" album="" material="solid_bm" texgens="-0.195089 0.980786 0 4.6792 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0.831617 0.55535 -2.83247e-008 -0.735551" album="" material="solid_bm" texgens="-0.555572 0.831468 0 14.0393 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0.555298 0.831652 -1.95044e-008 -0.735531" album="" material="solid_bm" texgens="-0.831471 0.555569 0 23.4103 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="3" plane="0.195461 0.980711 1.33144e-008 -0.735538" album="" material="solid_bm" texgens="-0.980786 0.195088 0 32.7745 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="4" plane="-0.19535 0.980734 0 -0.735545" album="" material="solid_bm" texgens="-0.980784 -0.195095 0 42.1397 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="5" plane="-0.555499 0.831517 2.01027e-008 -0.735554" album="" material="solid_bm" texgens="-0.831471 -0.555568 0 51.5062 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="6" plane="-0.831571 0.555418 -3.00933e-008 -0.73554" album="" material="solid_bm" texgens="-0.555573 -0.831468 0 60.8636 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="7" plane="-0.980765 0.195193 0 -0.735574" album="" material="solid_bm" texgens="-0.195092 -0.980785 0 70.2384 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 17 16 14 15" />
                        </Face>
                        <Face id="8" plane="-0.980765 -0.19519 -7.09849e-008 -0.735575" album="" material="solid_bm" texgens="0.195089 -0.980786 0 79.6007 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 19 18 16 17" />
                        </Face>
                        <Face id="9" plane="-0.83167 -0.55527 0 -0.735562" album="" material="solid_bm" texgens="0.555567 -0.831472 0 88.9565 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 21 20 18 19" />
                        </Face>
                        <Face id="10" plane="-0.555244 -0.831687 -1.95025e-008 -0.735539" album="" material="solid_bm" texgens="0.831471 -0.555569 0 98.3286 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 23 22 20 21" />
                        </Face>
                        <Face id="11" plane="-0.195435 -0.980717 -1.66414e-008 -0.73554" album="" material="solid_bm" texgens="0.980786 -0.195089 0 107.69 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 25 24 22 23" />
                        </Face>
                        <Face id="12" plane="0.195408 -0.980722 1.39351e-008 -0.735547" album="" material="solid_bm" texgens="0.980785 0.195092 0 117.055 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 27 26 24 25" />
                        </Face>
                        <Face id="13" plane="0.555349 -0.831617 -3.90123e-008 -0.735547" album="" material="solid_bm" texgens="0.831468 0.555572 0 126.421 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 29 28 26 27" />
                        </Face>
                        <Face id="14" plane="0.831619 -0.555346 3.00951e-008 -0.735551" album="" material="solid_bm" texgens="0.555569 0.83147 0 135.786 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 30 28 29" />
                        </Face>
                        <Face id="15" plane="0.980765 -0.195192 0 -0.735574" album="" material="solid_bm" texgens="0.195087 0.980786 0 145.144 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 3 2 30" />
                        </Face>
                        <Face id="16" plane="-0 0 -1 -11" album="" material="solid_bm" texgens="-1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 30 2 0 4 6 8 10 12 14 16 18 20 22 24 26 28" />
                        </Face>
                        <Face id="17" plane="0 -0 1 -17" album="" material="solid_bm" texgens="1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 29 27 25 23 21 19 17 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="228" owner="0" type="0" pos="2 22 -10" rot="1 0 0 0" scale="" transform="1 0 0 2 0 1 0 22 0 0 1 -10 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="17">
                        <Vertices>
                            <Vertex pos="2.12132 2.12125 -6" />
                            <Vertex pos="2.12132 2.12125 6" />
                            <Vertex pos="3 3.8147e-006 -6" />
                            <Vertex pos="3 3.8147e-006 6" />
                            <Vertex pos="-9.05991e-006 3 -6" />
                            <Vertex pos="-9.53674e-006 3 6" />
                            <Vertex pos="-2.12132 2.12125 -6" />
                            <Vertex pos="-2.12132 2.12125 6" />
                            <Vertex pos="-3 7.62939e-006 -6" />
                            <Vertex pos="-3 7.62939e-006 6" />
                            <Vertex pos="-2.12131 -2.12125 -6" />
                            <Vertex pos="-2.12131 -2.12125 6" />
                            <Vertex pos="4.76837e-006 -3 -6" />
                            <Vertex pos="4.76837e-006 -3 6" />
                            <Vertex pos="2.12134 -2.12126 -6" />
                            <Vertex pos="2.12134 -2.12126 6" />
                        </Vertices>
                        <Face id="0" plane="0.923875 0.382695 0 -2.77163" album="" material="bm_grid_blank1" texgens="-0.382684 0.92388 0 127.988 0 0 -1 768 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0.382708 0.923869 1.52073e-008 -2.7716" album="" material="bm_grid_blank1" texgens="-0.92388 0.382682 0 128.003 0 0 -1 768 0 0.287014 0.25" texRot="0" texScale="0.287014 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="-0.382711 0.923868 0 -2.77161" album="" material="bm_grid_blank1" texgens="-0.92388 -0.382683 0 128.006 0 0 -1 768 0 0.28701 0.25" texRot="0" texScale="0.28701 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="3" plane="-0.923874 0.382696 0 -2.77163" album="" material="bm_grid_blank1" texgens="-0.382687 -0.923878 0 128.014 0 0 -1 768 0 0.287014 0.25" texRot="0" texScale="0.287014 0.25" texDiv="256 256">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="4" plane="-0.923874 -0.382697 0 -2.77162" album="" material="bm_grid_blank1" texgens="0.382682 -0.92388 0 127.979 0 0 -1 768 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="5" plane="-0.382711 -0.923868 0 -2.7716" album="" material="bm_grid_blank1" texgens="0.92388 -0.382683 0 128.003 0 0 -1 768 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="6" plane="0.382704 -0.923871 0 -2.77162" album="" material="bm_grid_blank1" texgens="0.923878 0.382686 0 127.998 0 0 -1 768 0 0.287014 0.25" texRot="0" texScale="0.287014 0.25" texDiv="256 256">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="7" plane="0.923879 -0.382685 0 -2.77164" album="" material="bm_grid_blank1" texgens="0.382681 0.92388 0 128.025 0 0 -1 768 0 0.287011 0.25" texRot="0" texScale="0.287011 0.25" texDiv="256 256">
                            <Indices indices=" 15 3 2 14" />
                        </Face>
                        <Face id="8" plane="-0 0 -1 -6" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 14 2 0 4 6 8 10 12" />
                        </Face>
                        <Face id="9" plane="0 -0 1 -6" album="" material="bm_friction_grass" texgens="1 0 0 256 0 -1 0 -2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="229" owner="0" type="0" pos="2 22 7" rot="1 0 0 0" scale="" transform="1 0 0 2 0 1 0 22 0 0 1 7 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="33">
                        <Vertices>
                            <Vertex pos="0.692907 0.286877 -11" />
                            <Vertex pos="0.692909 0.286877 11" />
                            <Vertex pos="0.75 0 -11" />
                            <Vertex pos="0.75 0 11" />
                            <Vertex pos="0.530345 0.530308 -11" />
                            <Vertex pos="0.530346 0.530308 11" />
                            <Vertex pos="0.286971 0.69281 -11" />
                            <Vertex pos="0.286972 0.69281 11" />
                            <Vertex pos="2.47955e-005 0.75 -11" />
                            <Vertex pos="2.28882e-005 0.75 11" />
                            <Vertex pos="-0.287071 0.692814 -11" />
                            <Vertex pos="-0.287071 0.692814 11" />
                            <Vertex pos="-0.530313 0.530315 -11" />
                            <Vertex pos="-0.530312 0.530315 11" />
                            <Vertex pos="-0.692904 0.286884 -11" />
                            <Vertex pos="-0.692905 0.286884 11" />
                            <Vertex pos="-0.75 0 -11" />
                            <Vertex pos="-0.75 0 11" />
                            <Vertex pos="-0.692907 -0.286873 -11" />
                            <Vertex pos="-0.692909 -0.286873 11" />
                            <Vertex pos="-0.530376 -0.530308 -11" />
                            <Vertex pos="-0.530376 -0.530308 11" />
                            <Vertex pos="-0.286956 -0.692818 -11" />
                            <Vertex pos="-0.286957 -0.692818 11" />
                            <Vertex pos="1.00136e-005 -0.750004 -11" />
                            <Vertex pos="7.62939e-006 -0.750004 11" />
                            <Vertex pos="0.286997 -0.692822 -11" />
                            <Vertex pos="0.286995 -0.692822 11" />
                            <Vertex pos="0.53034 -0.530319 -11" />
                            <Vertex pos="0.530342 -0.530319 11" />
                            <Vertex pos="0.692906 -0.28688 -11" />
                            <Vertex pos="0.692905 -0.28688 11" />
                        </Vertices>
                        <Face id="0" plane="0.980767 0.195181 -9.03446e-008 -0.735574" album="" material="solid_bm" texgens="-0.195089 0.980786 0 4.6792 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0.831617 0.55535 -3.60496e-008 -0.735551" album="" material="solid_bm" texgens="-0.555572 0.831468 0 14.0393 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0.555298 0.831652 -2.48237e-008 -0.735531" album="" material="solid_bm" texgens="-0.831471 0.555569 0 23.4103 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="3" plane="0.195461 0.980711 1.69456e-008 -0.735538" album="" material="solid_bm" texgens="-0.980786 0.195088 0 32.7745 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="4" plane="-0.19535 0.980734 0 -0.735545" album="" material="solid_bm" texgens="-0.980784 -0.195095 0 42.1397 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="5" plane="-0.555499 0.831517 2.55852e-008 -0.735554" album="" material="solid_bm" texgens="-0.831471 -0.555568 0 51.5062 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="6" plane="-0.831571 0.555418 -3.83006e-008 -0.73554" album="" material="solid_bm" texgens="-0.555573 -0.831468 0 60.8636 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="7" plane="-0.980765 0.195193 0 -0.735574" album="" material="solid_bm" texgens="-0.195092 -0.980785 0 70.2384 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 17 16 14 15" />
                        </Face>
                        <Face id="8" plane="-0.980765 -0.19519 -9.03444e-008 -0.735575" album="" material="solid_bm" texgens="0.195089 -0.980786 0 79.6007 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 19 18 16 17" />
                        </Face>
                        <Face id="9" plane="-0.83167 -0.55527 0 -0.735562" album="" material="solid_bm" texgens="0.555567 -0.831472 0 88.9565 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 21 20 18 19" />
                        </Face>
                        <Face id="10" plane="-0.555244 -0.831687 -2.48213e-008 -0.735539" album="" material="solid_bm" texgens="0.831471 -0.555569 0 98.3286 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 23 22 20 21" />
                        </Face>
                        <Face id="11" plane="-0.195435 -0.980717 -2.11799e-008 -0.73554" album="" material="solid_bm" texgens="0.980786 -0.195089 0 107.69 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 25 24 22 23" />
                        </Face>
                        <Face id="12" plane="0.195408 -0.980722 1.77356e-008 -0.735547" album="" material="solid_bm" texgens="0.980785 0.195092 0 117.055 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 27 26 24 25" />
                        </Face>
                        <Face id="13" plane="0.555349 -0.831617 -4.96521e-008 -0.735547" album="" material="solid_bm" texgens="0.831468 0.555572 0 126.421 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 29 28 26 27" />
                        </Face>
                        <Face id="14" plane="0.831619 -0.555347 3.83028e-008 -0.735551" album="" material="solid_bm" texgens="0.555569 0.83147 0 135.786 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 30 28 29" />
                        </Face>
                        <Face id="15" plane="0.980765 -0.195192 0 -0.735574" album="" material="solid_bm" texgens="0.195087 0.980786 0 145.144 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 3 2 30" />
                        </Face>
                        <Face id="16" plane="-0 0 -1 -11" album="" material="solid_bm" texgens="-1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 30 2 0 4 6 8 10 12 14 16 18 20 22 24 26 28" />
                        </Face>
                        <Face id="17" plane="0 -0 1 -11" album="" material="solid_bm" texgens="1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 29 27 25 23 21 19 17 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="230" owner="0" type="0" pos="-26 46 -10" rot="1 0 0 0" scale="" transform="1 0 0 -26 0 1 0 46 0 0 1 -10 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="17">
                        <Vertices>
                            <Vertex pos="2.12132 2.12125 -6" />
                            <Vertex pos="2.12132 2.12125 2" />
                            <Vertex pos="3 3.8147e-006 -6" />
                            <Vertex pos="3 3.8147e-006 2" />
                            <Vertex pos="-9.05991e-006 3 -6" />
                            <Vertex pos="-9.53674e-006 3 2" />
                            <Vertex pos="-2.12132 2.12125 -6" />
                            <Vertex pos="-2.12132 2.12125 2" />
                            <Vertex pos="-3 7.62939e-006 -6" />
                            <Vertex pos="-3 7.62939e-006 2" />
                            <Vertex pos="-2.12131 -2.12125 -6" />
                            <Vertex pos="-2.12131 -2.12125 2" />
                            <Vertex pos="4.76837e-006 -3 -6" />
                            <Vertex pos="4.76837e-006 -3 2" />
                            <Vertex pos="2.12134 -2.12126 -6" />
                            <Vertex pos="2.12134 -2.12126 2" />
                        </Vertices>
                        <Face id="0" plane="0.923875 0.382695 0 -2.77163" album="" material="bm_grid_blank1" texgens="-0.382684 0.92388 0 127.988 0 0 -1 768 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0.382708 0.923869 2.28109e-008 -2.7716" album="" material="bm_grid_blank1" texgens="-0.92388 0.382682 0 128.003 0 0 -1 768 0 0.287014 0.25" texRot="0" texScale="0.287014 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="-0.382711 0.923868 0 -2.77161" album="" material="bm_grid_blank1" texgens="-0.92388 -0.382683 0 128.006 0 0 -1 768 0 0.28701 0.25" texRot="0" texScale="0.28701 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="3" plane="-0.923875 0.382696 0 -2.77163" album="" material="bm_grid_blank1" texgens="-0.382687 -0.923878 0 128.014 0 0 -1 768 0 0.287014 0.25" texRot="0" texScale="0.287014 0.25" texDiv="256 256">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="4" plane="-0.923874 -0.382697 0 -2.77162" album="" material="bm_grid_blank1" texgens="0.382682 -0.92388 0 127.979 0 0 -1 768 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="5" plane="-0.38271 -0.923868 0 -2.7716" album="" material="bm_grid_blank1" texgens="0.92388 -0.382683 0 128.003 0 0 -1 768 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="6" plane="0.382704 -0.923871 0 -2.77162" album="" material="bm_grid_blank1" texgens="0.923878 0.382686 0 127.998 0 0 -1 768 0 0.287014 0.25" texRot="0" texScale="0.287014 0.25" texDiv="256 256">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="7" plane="0.923879 -0.382685 0 -2.77164" album="" material="bm_grid_blank1" texgens="0.382681 0.92388 0 128.025 0 0 -1 768 0 0.287011 0.25" texRot="0" texScale="0.287011 0.25" texDiv="256 256">
                            <Indices indices=" 15 3 2 14" />
                        </Face>
                        <Face id="8" plane="-0 0 -1 -6" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 14 2 0 4 6 8 10 12" />
                        </Face>
                        <Face id="9" plane="0 -0 1 -2" album="" material="bm_friction_grass" texgens="1 0 0 -3328 0 -1 0 -5888 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="231" owner="0" type="0" pos="-26 46 3" rot="1 0 0 0" scale="" transform="1 0 0 -26 0 1 0 46 0 0 1 3 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="33">
                        <Vertices>
                            <Vertex pos="0.692907 0.286877 -11" />
                            <Vertex pos="0.692909 0.286877 15" />
                            <Vertex pos="0.75 0 -11" />
                            <Vertex pos="0.75 0 15" />
                            <Vertex pos="0.530345 0.530308 -11" />
                            <Vertex pos="0.530346 0.530308 15" />
                            <Vertex pos="0.286971 0.69281 -11" />
                            <Vertex pos="0.286972 0.69281 15" />
                            <Vertex pos="2.47955e-005 0.75 -11" />
                            <Vertex pos="2.28882e-005 0.75 15" />
                            <Vertex pos="-0.287071 0.692814 -11" />
                            <Vertex pos="-0.287071 0.692814 15" />
                            <Vertex pos="-0.530313 0.530315 -11" />
                            <Vertex pos="-0.530312 0.530315 15" />
                            <Vertex pos="-0.692904 0.286884 -11" />
                            <Vertex pos="-0.692905 0.286884 15" />
                            <Vertex pos="-0.75 0 -11" />
                            <Vertex pos="-0.75 0 15" />
                            <Vertex pos="-0.692907 -0.286873 -11" />
                            <Vertex pos="-0.692909 -0.286873 15" />
                            <Vertex pos="-0.530376 -0.530308 -11" />
                            <Vertex pos="-0.530376 -0.530308 15" />
                            <Vertex pos="-0.286956 -0.692818 -11" />
                            <Vertex pos="-0.286957 -0.692818 15" />
                            <Vertex pos="1.00136e-005 -0.750004 -11" />
                            <Vertex pos="7.62939e-006 -0.750004 15" />
                            <Vertex pos="0.286997 -0.692822 -11" />
                            <Vertex pos="0.286995 -0.692822 15" />
                            <Vertex pos="0.53034 -0.530319 -11" />
                            <Vertex pos="0.530342 -0.530319 15" />
                            <Vertex pos="0.692906 -0.28688 -11" />
                            <Vertex pos="0.692905 -0.28688 15" />
                        </Vertices>
                        <Face id="0" plane="0.980767 0.195181 -7.64454e-008 -0.735574" album="" material="solid_bm" texgens="-0.195089 0.980786 0 4.6792 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0.831617 0.55535 -3.05035e-008 -0.735551" album="" material="solid_bm" texgens="-0.555572 0.831468 0 14.0393 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0.555298 0.831652 -2.10047e-008 -0.735531" album="" material="solid_bm" texgens="-0.831471 0.555569 0 23.4103 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="3" plane="0.195461 0.980711 1.43386e-008 -0.735538" album="" material="solid_bm" texgens="-0.980786 0.195088 0 32.7745 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="4" plane="-0.19535 0.980734 0 -0.735545" album="" material="solid_bm" texgens="-0.980784 -0.195095 0 42.1397 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="5" plane="-0.555499 0.831517 2.16491e-008 -0.735554" album="" material="solid_bm" texgens="-0.831471 -0.555568 0 51.5062 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="6" plane="-0.831571 0.555418 -3.24082e-008 -0.73554" album="" material="solid_bm" texgens="-0.555573 -0.831468 0 60.8636 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="7" plane="-0.980765 0.195193 0 -0.735574" album="" material="solid_bm" texgens="-0.195092 -0.980785 0 70.2384 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 17 16 14 15" />
                        </Face>
                        <Face id="8" plane="-0.980765 -0.19519 -7.64453e-008 -0.735575" album="" material="solid_bm" texgens="0.195089 -0.980786 0 79.6007 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 19 18 16 17" />
                        </Face>
                        <Face id="9" plane="-0.83167 -0.55527 0 -0.735562" album="" material="solid_bm" texgens="0.555567 -0.831472 0 88.9565 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 21 20 18 19" />
                        </Face>
                        <Face id="10" plane="-0.555244 -0.831688 -2.10027e-008 -0.735539" album="" material="solid_bm" texgens="0.831471 -0.555569 0 98.3286 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 23 22 20 21" />
                        </Face>
                        <Face id="11" plane="-0.195435 -0.980717 -1.79215e-008 -0.73554" album="" material="solid_bm" texgens="0.980786 -0.195089 0 107.69 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 25 24 22 23" />
                        </Face>
                        <Face id="12" plane="0.195408 -0.980722 1.5007e-008 -0.735547" album="" material="solid_bm" texgens="0.980785 0.195092 0 117.055 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 27 26 24 25" />
                        </Face>
                        <Face id="13" plane="0.555349 -0.831617 -4.20133e-008 -0.735547" album="" material="solid_bm" texgens="0.831468 0.555572 0 126.421 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 29 28 26 27" />
                        </Face>
                        <Face id="14" plane="0.831619 -0.555346 3.24101e-008 -0.735551" album="" material="solid_bm" texgens="0.555569 0.83147 0 135.786 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 30 28 29" />
                        </Face>
                        <Face id="15" plane="0.980765 -0.195192 0 -0.735574" album="" material="solid_bm" texgens="0.195087 0.980786 0 145.144 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 3 2 30" />
                        </Face>
                        <Face id="16" plane="-0 0 -1 -11" album="" material="solid_bm" texgens="-1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 30 2 0 4 6 8 10 12 14 16 18 20 22 24 26 28" />
                        </Face>
                        <Face id="17" plane="0 -0 1 -15" album="" material="solid_bm" texgens="1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 29 27 25 23 21 19 17 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="232" owner="0" type="0" pos="22 -10 -10" rot="1 0 0 0" scale="" transform="1 0 0 22 0 1 0 -10 0 0 1 -10 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="17">
                        <Vertices>
                            <Vertex pos="2.12132 2.12125 -6" />
                            <Vertex pos="2.12132 2.12125 6" />
                            <Vertex pos="3 3.8147e-006 -6" />
                            <Vertex pos="3 3.8147e-006 6" />
                            <Vertex pos="-9.05991e-006 3 -6" />
                            <Vertex pos="-9.53674e-006 3 6" />
                            <Vertex pos="-2.12132 2.12125 -6" />
                            <Vertex pos="-2.12132 2.12125 6" />
                            <Vertex pos="-3 7.62939e-006 -6" />
                            <Vertex pos="-3 7.62939e-006 6" />
                            <Vertex pos="-2.12131 -2.12125 -6" />
                            <Vertex pos="-2.12131 -2.12125 6" />
                            <Vertex pos="4.76837e-006 -3 -6" />
                            <Vertex pos="3.8147e-006 -3 6" />
                            <Vertex pos="2.12134 -2.12126 -6" />
                            <Vertex pos="2.12134 -2.12126 6" />
                        </Vertices>
                        <Face id="0" plane="0.923875 0.382695 0 -2.77163" album="" material="bm_grid_blank1" texgens="-0.382684 0.92388 0 127.988 0 0 -1 768 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0.382708 0.923869 1.52073e-008 -2.7716" album="" material="bm_grid_blank1" texgens="-0.92388 0.382682 0 128.003 0 0 -1 768 0 0.287014 0.25" texRot="0" texScale="0.287014 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="-0.382711 0.923868 0 -2.77161" album="" material="bm_grid_blank1" texgens="-0.92388 -0.382683 0 128.006 0 0 -1 768 0 0.28701 0.25" texRot="0" texScale="0.28701 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="3" plane="-0.923874 0.382696 0 -2.77163" album="" material="bm_grid_blank1" texgens="-0.382687 -0.923878 0 128.014 0 0 -1 768 0 0.287014 0.25" texRot="0" texScale="0.287014 0.25" texDiv="256 256">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="4" plane="-0.923874 -0.382697 0 -2.77162" album="" material="bm_grid_blank1" texgens="0.382682 -0.92388 0 127.979 0 0 -1 768 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="5" plane="-0.382711 -0.923868 -3.0415e-008 -2.7716" album="" material="bm_grid_blank1" texgens="0.92388 -0.382683 0 128.003 0 0 -1 768 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="6" plane="0.382704 -0.923871 0 -2.77162" album="" material="bm_grid_blank1" texgens="0.923878 0.382686 0 127.998 0 0 -1 768 0 0.287014 0.25" texRot="0" texScale="0.287014 0.25" texDiv="256 256">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="7" plane="0.923879 -0.382685 0 -2.77164" album="" material="bm_grid_blank1" texgens="0.382681 0.92388 0 128.025 0 0 -1 768 0 0.287011 0.25" texRot="0" texScale="0.287011 0.25" texDiv="256 256">
                            <Indices indices=" 15 3 2 14" />
                        </Face>
                        <Face id="8" plane="-0 0 -1 -6" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 14 2 0 4 6 8 10 12" />
                        </Face>
                        <Face id="9" plane="0 -0 1 -6" album="" material="bm_friction_grass" texgens="1 0 0 2816 0 -1 0 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="233" owner="0" type="0" pos="22 -10 3" rot="1 0 0 0" scale="" transform="1 0 0 22 0 1 0 -10 0 0 1 3 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="33">
                        <Vertices>
                            <Vertex pos="0.692907 0.286877 -7" />
                            <Vertex pos="0.692909 0.286877 23" />
                            <Vertex pos="0.75 0 -7" />
                            <Vertex pos="0.75 0 23" />
                            <Vertex pos="0.530346 0.530308 -7" />
                            <Vertex pos="0.530346 0.530308 23" />
                            <Vertex pos="0.28697 0.69281 -7" />
                            <Vertex pos="0.286972 0.69281 23" />
                            <Vertex pos="2.47955e-005 0.75 -7" />
                            <Vertex pos="2.28882e-005 0.75 23" />
                            <Vertex pos="-0.287071 0.692814 -7" />
                            <Vertex pos="-0.287071 0.692814 23" />
                            <Vertex pos="-0.530313 0.530315 -7" />
                            <Vertex pos="-0.530312 0.530315 23" />
                            <Vertex pos="-0.692904 0.286884 -7" />
                            <Vertex pos="-0.692905 0.286884 23" />
                            <Vertex pos="-0.75 0 -7" />
                            <Vertex pos="-0.75 0 23" />
                            <Vertex pos="-0.692907 -0.286873 -7" />
                            <Vertex pos="-0.692909 -0.286873 23" />
                            <Vertex pos="-0.530376 -0.530308 -7" />
                            <Vertex pos="-0.530376 -0.530308 23" />
                            <Vertex pos="-0.286957 -0.692818 -7" />
                            <Vertex pos="-0.286957 -0.692818 23" />
                            <Vertex pos="9.53674e-006 -0.750004 -7" />
                            <Vertex pos="7.62939e-006 -0.750004 23" />
                            <Vertex pos="0.286997 -0.692822 -7" />
                            <Vertex pos="0.286995 -0.692822 23" />
                            <Vertex pos="0.53034 -0.530319 -7" />
                            <Vertex pos="0.530342 -0.530319 23" />
                            <Vertex pos="0.692905 -0.28688 -7" />
                            <Vertex pos="0.692905 -0.28688 23" />
                        </Vertices>
                        <Face id="0" plane="0.980767 0.195181 -6.62527e-008 -0.735574" album="" material="solid_bm" texgens="-0.195089 0.980786 0 4.6792 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0.831618 0.555347 -0 -0.735551" album="" material="solid_bm" texgens="-0.555572 0.831468 0 14.0393 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0.555295 0.831654 -3.69596e-008 -0.735531" album="" material="solid_bm" texgens="-0.831471 0.555569 0 23.4103 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="3" plane="0.195462 0.980711 1.24268e-008 -0.735538" album="" material="solid_bm" texgens="-0.980786 0.195088 0 32.7745 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="4" plane="-0.19535 0.980734 0 -0.735545" album="" material="solid_bm" texgens="-0.980784 -0.195095 0 42.1397 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="5" plane="-0.555499 0.831517 1.87625e-008 -0.735554" album="" material="solid_bm" texgens="-0.831471 -0.555568 0 51.5062 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="6" plane="-0.831571 0.555418 -2.80871e-008 -0.73554" album="" material="solid_bm" texgens="-0.555573 -0.831468 0 60.8636 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="7" plane="-0.980765 0.195193 0 -0.735574" album="" material="solid_bm" texgens="-0.195092 -0.980785 0 70.2384 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 17 16 14 15" />
                        </Face>
                        <Face id="8" plane="-0.980765 -0.19519 -6.62526e-008 -0.735574" album="" material="solid_bm" texgens="0.195089 -0.980786 0 79.6007 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 19 18 16 17" />
                        </Face>
                        <Face id="9" plane="-0.83167 -0.55527 0 -0.735562" album="" material="solid_bm" texgens="0.555567 -0.831472 0 88.9565 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 21 20 18 19" />
                        </Face>
                        <Face id="10" plane="-0.555246 -0.831686 0 -0.735539" album="" material="solid_bm" texgens="0.831471 -0.555569 0 98.3286 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 23 22 20 21" />
                        </Face>
                        <Face id="11" plane="-0.195435 -0.980717 -1.24254e-008 -0.73554" album="" material="solid_bm" texgens="0.980786 -0.195089 0 107.69 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 25 24 22 23" />
                        </Face>
                        <Face id="12" plane="0.195408 -0.980722 1.30061e-008 -0.735547" album="" material="solid_bm" texgens="0.980785 0.195092 0 117.055 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 27 26 24 25" />
                        </Face>
                        <Face id="13" plane="0.555349 -0.831617 -3.64115e-008 -0.735547" album="" material="solid_bm" texgens="0.831468 0.555572 0 126.421 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 29 28 26 27" />
                        </Face>
                        <Face id="14" plane="0.831621 -0.555344 0 -0.735551" album="" material="solid_bm" texgens="0.555569 0.83147 0 135.786 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 30 28 29" />
                        </Face>
                        <Face id="15" plane="0.980765 -0.195192 0 -0.735574" album="" material="solid_bm" texgens="0.195087 0.980786 0 145.144 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 3 2 30" />
                        </Face>
                        <Face id="16" plane="-0 0 -1 -7" album="" material="solid_bm" texgens="-1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 30 2 0 4 6 8 10 12 14 16 18 20 22 24 26 28" />
                        </Face>
                        <Face id="17" plane="0 -0 1 -23" album="" material="solid_bm" texgens="1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 29 27 25 23 21 19 17 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="234" owner="0" type="0" pos="-17 -14 -10" rot="1 0 0 0" scale="" transform="1 0 0 -17 0 1 0 -14 0 0 1 -10 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="17">
                        <Vertices>
                            <Vertex pos="2.12132 2.12125 -6" />
                            <Vertex pos="2.12132 2.12125 2" />
                            <Vertex pos="3 3.8147e-006 -6" />
                            <Vertex pos="3 3.8147e-006 2" />
                            <Vertex pos="-9.05991e-006 3 -6" />
                            <Vertex pos="-9.53674e-006 3 2" />
                            <Vertex pos="-2.12132 2.12125 -6" />
                            <Vertex pos="-2.12132 2.12125 2" />
                            <Vertex pos="-3 7.62939e-006 -6" />
                            <Vertex pos="-3 7.62939e-006 2" />
                            <Vertex pos="-2.12131 -2.12125 -6" />
                            <Vertex pos="-2.12131 -2.12125 2" />
                            <Vertex pos="4.76837e-006 -3 -6" />
                            <Vertex pos="4.76837e-006 -3 2" />
                            <Vertex pos="2.12134 -2.12126 -6" />
                            <Vertex pos="2.12134 -2.12126 2" />
                        </Vertices>
                        <Face id="0" plane="0.923875 0.382695 0 -2.77163" album="" material="bm_grid_blank1" texgens="-0.382684 0.92388 0 127.988 0 0 -1 768 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0.382708 0.923869 2.28109e-008 -2.7716" album="" material="bm_grid_blank1" texgens="-0.92388 0.382682 0 128.003 0 0 -1 768 0 0.287014 0.25" texRot="0" texScale="0.287014 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="-0.382711 0.923868 0 -2.77161" album="" material="bm_grid_blank1" texgens="-0.92388 -0.382683 0 128.006 0 0 -1 768 0 0.28701 0.25" texRot="0" texScale="0.28701 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="3" plane="-0.923875 0.382696 0 -2.77163" album="" material="bm_grid_blank1" texgens="-0.382687 -0.923878 0 128.014 0 0 -1 768 0 0.287014 0.25" texRot="0" texScale="0.287014 0.25" texDiv="256 256">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="4" plane="-0.923874 -0.382697 0 -2.77162" album="" material="bm_grid_blank1" texgens="0.382682 -0.92388 0 127.979 0 0 -1 768 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="5" plane="-0.38271 -0.923868 0 -2.7716" album="" material="bm_grid_blank1" texgens="0.92388 -0.382683 0 128.003 0 0 -1 768 0 0.287013 0.25" texRot="0" texScale="0.287013 0.25" texDiv="256 256">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="6" plane="0.382704 -0.923871 0 -2.77162" album="" material="bm_grid_blank1" texgens="0.923878 0.382686 0 127.998 0 0 -1 768 0 0.287014 0.25" texRot="0" texScale="0.287014 0.25" texDiv="256 256">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="7" plane="0.923879 -0.382685 0 -2.77164" album="" material="bm_grid_blank1" texgens="0.382681 0.92388 0 128.025 0 0 -1 768 0 0.287011 0.25" texRot="0" texScale="0.287011 0.25" texDiv="256 256">
                            <Indices indices=" 15 3 2 14" />
                        </Face>
                        <Face id="8" plane="-0 0 -1 -6" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 14 2 0 4 6 8 10 12" />
                        </Face>
                        <Face id="9" plane="0 -0 1 -2" album="" material="bm_friction_grass" texgens="1 0 0 -2176 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="235" owner="0" type="0" pos="-17 -14 3" rot="1 0 0 0" scale="" transform="1 0 0 -17 0 1 0 -14 0 0 1 3 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="33">
                        <Vertices>
                            <Vertex pos="0.692907 0.286877 -11" />
                            <Vertex pos="0.692909 0.286877 11" />
                            <Vertex pos="0.75 0 -11" />
                            <Vertex pos="0.75 0 11" />
                            <Vertex pos="0.530345 0.530308 -11" />
                            <Vertex pos="0.530346 0.530308 11" />
                            <Vertex pos="0.286971 0.69281 -11" />
                            <Vertex pos="0.286972 0.69281 11" />
                            <Vertex pos="2.47955e-005 0.75 -11" />
                            <Vertex pos="2.28882e-005 0.75 11" />
                            <Vertex pos="-0.287071 0.692814 -11" />
                            <Vertex pos="-0.287071 0.692814 11" />
                            <Vertex pos="-0.530313 0.530315 -11" />
                            <Vertex pos="-0.530312 0.530315 11" />
                            <Vertex pos="-0.692904 0.286884 -11" />
                            <Vertex pos="-0.692905 0.286884 11" />
                            <Vertex pos="-0.75 0 -11" />
                            <Vertex pos="-0.75 0 11" />
                            <Vertex pos="-0.692907 -0.286873 -11" />
                            <Vertex pos="-0.692909 -0.286873 11" />
                            <Vertex pos="-0.530376 -0.530308 -11" />
                            <Vertex pos="-0.530376 -0.530308 11" />
                            <Vertex pos="-0.286956 -0.692818 -11" />
                            <Vertex pos="-0.286957 -0.692818 11" />
                            <Vertex pos="1.00136e-005 -0.750004 -11" />
                            <Vertex pos="7.62939e-006 -0.750004 11" />
                            <Vertex pos="0.286997 -0.692822 -11" />
                            <Vertex pos="0.286995 -0.692822 11" />
                            <Vertex pos="0.53034 -0.530319 -11" />
                            <Vertex pos="0.530342 -0.530319 11" />
                            <Vertex pos="0.692906 -0.28688 -11" />
                            <Vertex pos="0.692905 -0.28688 11" />
                        </Vertices>
                        <Face id="0" plane="0.980767 0.195181 -9.8065e-008 -0.735574" album="" material="solid_bm" texgens="-0.195089 0.980786 0 4.6792 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0.831617 0.55535 -2.77781e-008 -0.735551" album="" material="solid_bm" texgens="-0.555572 0.831468 0 14.0393 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0.555298 0.831652 -2.85814e-008 -0.735531" album="" material="solid_bm" texgens="-0.831471 0.555569 0 23.4103 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="3" plane="0.195461 0.980711 1.69457e-008 -0.735538" album="" material="solid_bm" texgens="-0.980786 0.195088 0 32.7745 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="4" plane="-0.19535 0.980734 3.19716e-009 -0.735545" album="" material="solid_bm" texgens="-0.980784 -0.195095 0 42.1397 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="5" plane="-0.555499 0.831517 2.03505e-008 -0.735554" album="" material="solid_bm" texgens="-0.831471 -0.555568 0 51.5062 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="6" plane="-0.831571 0.555418 -6.15954e-008 -0.73554" album="" material="solid_bm" texgens="-0.555573 -0.831468 0 60.8636 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="7" plane="-0.980765 0.195193 0 -0.735574" album="" material="solid_bm" texgens="-0.195092 -0.980785 0 70.2384 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 17 16 14 15" />
                        </Face>
                        <Face id="8" plane="-0.980765 -0.19519 -9.96511e-008 -0.735575" album="" material="solid_bm" texgens="0.195089 -0.980786 0 79.6007 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 19 18 16 17" />
                        </Face>
                        <Face id="9" plane="-0.83167 -0.55527 -9.75514e-009 -0.735562" album="" material="solid_bm" texgens="0.555567 -0.831472 0 88.9565 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 21 20 18 19" />
                        </Face>
                        <Face id="10" plane="-0.555244 -0.831687 -8.28975e-009 -0.735539" album="" material="solid_bm" texgens="0.831471 -0.555569 0 98.3286 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 23 22 20 21" />
                        </Face>
                        <Face id="11" plane="-0.195435 -0.980717 -1.32087e-008 -0.73554" album="" material="solid_bm" texgens="0.980786 -0.195089 0 107.69 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 25 24 22 23" />
                        </Face>
                        <Face id="12" plane="0.195408 -0.980722 3.95216e-008 -0.735547" album="" material="solid_bm" texgens="0.980785 0.195092 0 117.055 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 27 26 24 25" />
                        </Face>
                        <Face id="13" plane="0.555349 -0.831617 -6.16737e-008 -0.735547" album="" material="solid_bm" texgens="0.831468 0.555572 0 126.421 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 29 28 26 27" />
                        </Face>
                        <Face id="14" plane="0.831619 -0.555347 3.38156e-008 -0.735551" album="" material="solid_bm" texgens="0.555569 0.83147 0 135.786 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 30 28 29" />
                        </Face>
                        <Face id="15" plane="0.980765 -0.195191 0 -0.735574" album="" material="solid_bm" texgens="0.195087 0.980786 0 145.144 0 0 -1 -352 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 3 2 30" />
                        </Face>
                        <Face id="16" plane="-0 0 -1 -11" album="" material="solid_bm" texgens="-1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 30 2 0 4 6 8 10 12 14 16 18 20 22 24 26 28" />
                        </Face>
                        <Face id="17" plane="0 -0 1 -11" album="" material="solid_bm" texgens="1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 29 27 25 23 21 19 17 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                </Brushes>
            </InteriorMap>
        </DetailLevel>
    </DetailLevels>
</ConstructorScene>
